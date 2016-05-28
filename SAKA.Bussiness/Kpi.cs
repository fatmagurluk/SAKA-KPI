using SAKA.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAKA.Bussiness
{
    public class Kpi
    {

        public static DTO_ScoreCard[] GetScoreCard()
        {
            using (var dc = new SAKADataDataContext())
            {
                var kpiList = dc.KPIs.Where(kpi => kpi.KPI_Values.Any()).Select(kpi => new
                {
                    kpi.ID,
                    kpi.Name,
                    kpi.Target,
                    kpi.Unit,
                    kpi.Threshold,
                    kpi.ThresholdType,
                    kpi.Period,
                    kpi.Direction
                }).ToList();

                var scorelist = new List<DTO_ScoreCard>();

                foreach (var kpiitem in kpiList)
                {
                    var kpivalue = dc.KPI_Values.Where(kpivalueitem => kpivalueitem.KPI_ID == kpiitem.ID).OrderByDescending(kpivalueitem => kpivalueitem.KPIDate).Select(kpivalueitem => new { kpivalueitem.Value, kpivalueitem.KPIDate }).First();

                    var scorecarditem = new DTO_ScoreCard();

                    scorecarditem.NAME = kpiitem.Name;
                    scorecarditem.UNIT = kpiitem.Unit;
                    scorecarditem.VALUE = kpivalue.Value;
                    scorecarditem.DATE = kpivalue.KPIDate;
                    scorecarditem.PERIOD = (Period)kpiitem.Period;
                    scorecarditem.STATU = Kpi.CalculateStatu(kpivalue.Value, kpiitem.Threshold, kpiitem.ThresholdType, kpiitem.Target, kpiitem.Direction);

                    scorelist.Add(scorecarditem);
                }

                return scorelist.ToArray();
            }
        }
        // LINQ diğer sorgu yöntemi
        //var kpiList = (from kpiitem in dc.KPIs
        //                 where kpiitem.KPI_Values.Any()
        //               select kpiitem).ToList();

        private static Statu CalculateStatu(decimal value, decimal threshold, bool threshold_type, decimal target, bool direction)
        {
            // target değerinden sapma değeri
            // 0 => %
            // 1=> değer

            decimal sapma = threshold_type ? threshold : target * threshold / 100;

            if (value > target + sapma)
            {
                return direction ? Statu.Good : Statu.Bad;
            }

            if (value < target - sapma)
            {
                return direction ? Statu.Bad : Statu.Good;
            }

            return Statu.Notr;
            /*
                decimal sapma = 0;
                if (threshold_type)
                {
                    sapma = threshold;
                }
                else
                {
                    sapma = target * threshold / 100;
                }
            */
        }

        public static DTO_Gauge[] GetGauge()
        {
            using (var dc = new SAKADataDataContext())
            {
                var listKpi = dc.KPIs.Where(c => c.KPI_Values.Any()).Select(c => new
                {
                    c.Name,
                    c.ID,
                    c.Threshold,
                    c.ThresholdType,
                    c.Direction,
                    c.Target,
                    c.Unit
                });

                var listGauge = new List<DTO_Gauge>();

                foreach (var dto in listKpi)
                {
                    var value = dc.KPI_Values.Where(c => c.KPI_ID == dto.ID).Select(c => new { c.Value, c.KPIDate }).OrderByDescending(c => c.KPIDate).First();
                    var item = new DTO_Gauge();
                    var sapma = dto.ThresholdType ? dto.Threshold : dto.Target * dto.Threshold / 100;
                    item.NAME = dto.Name;
                    item.UNIT = dto.Unit;
                    item.VALUE = value.Value;
                    item.DIRECTION = dto.Direction == true ? Direction.positive : Direction.negative;
                    item.TARGET_MAX = dto.Target + sapma;
                    item.TARGET_MIN = dto.Target - sapma;

                    listGauge.Add(item);

                }
                return listGauge.ToArray();
            }
        }
    }
}
