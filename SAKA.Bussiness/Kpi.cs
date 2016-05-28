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
            var scorelist = new List<DTO_ScoreCard>();

            using (var dc = new SAKADataDataContext())
            {
                var kpiList = dc.KPIs.Where(kpi => kpi.KPI_Values.Any()).Select(kpi => new { kpi.ID, kpi.Name, kpi.Target, kpi.Unit, kpi.Threshold, kpi.ThresholdType, kpi.Period, kpi.Direction }).ToList();


                foreach (var kpiitem in kpiList)
                {
                    var kpivalue = dc.KPI_Values.Where(kpivalueitem=> kpivalueitem.KPI_ID == kpiitem.ID).OrderByDescending(kpivalueitem => kpivalueitem.KPIDate).Select(kpivalueitem => new {kpivalueitem.Value, kpivalueitem.KPIDate}).First();

                    var scorecarditem = new DTO_ScoreCard();
                    scorecarditem.NAME = kpiitem.Name;
                    scorecarditem.UNIT = kpiitem.Unit;
                    scorecarditem.VALUE = kpivalue.Value;
                    scorecarditem.DATE = kpivalue.KPIDate;
                    scorecarditem.PERIOD = (Period)kpiitem.Period;
                    scorecarditem.STATU = CalculateStatu(kpivalue.Value, kpiitem.Threshold, kpiitem.ThresholdType, kpiitem.Target, kpiitem.Direction);

                        scorelist.Add(scorecarditem);
                }

                // LINQ diğer sorgu yöntemi
                //var kpiList = (from kpiitem in dc.KPIs
                //                 where kpiitem.KPI_Values.Any()
                //               select kpiitem).ToList();
            }

            
            return scorelist.ToArray();
        }

        private static Statu CalculateStatu(decimal value, decimal threshold, bool threshold_type, decimal target,bool direction)
        {
            // target değerinden sapma değeri
            // 0 => %
            // 1=> değer
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
        }

        //public static int count()
        //{
        //    return 5;
        //}

        //public static void getStudents()
        //{
        //    var list = new List<DTO_Student>();

        //    var student = new DTO_Student[]
        //    {
        //        new DTO_Student(1,"fatma",90),
        //        new DTO_Student(2,"ayşe", 95),
        //        new DTO_Student(3,"mahmut",80),
        //        new DTO_Student(4,"zeynep",85)
        //    };

        //    list.AddRange(student);

        //    var sorgu1 = list.Where(x=> x.Score >85).Select(c=> c.Name).ToList();

        //    /*var sorgu1 = (from x in list where x.SCORE >= 50 select x.NAME).ToList(); */

        //    foreach (var k in sorgu1)
        //    {
        //        Console.WriteLine(k);
        //    }

        //    var sorgu2 = list.Where(y => y.Name.StartsWith("f")).Select(y => new {y.Name,y.Score}).ToList();

        //    foreach (var k in sorgu2)
        //    {
        //        Console.WriteLine(k.Name + ":" + k.Score);
        //    }

        //    var sorgu3 = list.Select(c => new {c.Name,c.Score }).OrderBy(c=> c.Score).ToList();
        //}


        //public static int sum()
        //{
        //    return 1234;
        //}       

        //public static string AppKpi()
        //{
        //    using (SAKADataDataContext dc = new SAKADataDataContext())
        //    {
        //        var kpi = new KPI();
        //        kpi.ID = Guid.NewGuid();
        //        kpi.Name = "Müşteri Adet";
        //        kpi.Target = 30;
        //        kpi.Threshold = 3;
        //        kpi.ThresholdType = true; // 0 değer, 1 yüzde
        //        kpi.Period ='Y';
        //        kpi.Unit = "adet";
        //        kpi.Direction = true;
        //        kpi.CreationDate = DateTime.Now;

        //        dc.KPIs.InsertOnSubmit(kpi);
        //        dc.SubmitChanges();

        //        return kpi.Name;
        //    }
        //}

        //public static string GetKpi()
        //{
        //    using (SAKADataDataContext dc = new SAKADataDataContext())
        //    {
        //        var list = dc.KPIs.Where(x => x.Name == "Ciro").Select(c => new { c.ID, c.Target, c.Name, c.Threshold}).ToList();

        //        var KpiList = new List<DTO_ScoreCard>();

        //        foreach (var k in list)
        //        {
        //            var item = new DTO_ScoreCard();
        //            item.NAME = k.Name;

        //            list.Add(item);                    
        //        }

        //        return KpiList.ToArray();
        //    }


        //}
        //}
    }
}
