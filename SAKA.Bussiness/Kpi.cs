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
        public static int count()
        {
            return 5;
        }

        public static void getStudents()
        {
            var list = new List<DTO_Student>();

            var student = new DTO_Student[]
            {
                new DTO_Student(1,"fatma",90),
                new DTO_Student(2,"ayşe", 95),
                new DTO_Student(3,"mahmut",80),
                new DTO_Student(4,"zeynep",85)
            };

            list.AddRange(student);

            var sorgu1 = list.Where(x=> x.Score >85).Select(c=> c.Name).ToList();

            /*var sorgu1 = (from x in list where x.SCORE >= 50 select x.NAME).ToList(); */

            foreach (var k in sorgu1)
            {
                Console.WriteLine(k);
            }

            var sorgu2 = list.Where(y => y.Name.StartsWith("f")).Select(y => new {y.Name,y.Score}).ToList();

            foreach (var k in sorgu2)
            {
                Console.WriteLine(k.Name + ":" + k.Score);
            }

            var sorgu3 = list.Select(c => new {c.Name,c.Score }).OrderBy(c=> c.Score).ToList();
        }


        public static int sum()
        {
            return 1234;
        }       

        public static string AppKpi()
        {
            using (SAKADataDataContext dc = new SAKADataDataContext())
            {
                var kpi = new KPI();
                kpi.ID = Guid.NewGuid();
                kpi.Name = "Müşteri Adet";
                kpi.Target = 30;
                kpi.Threshold = 3;
                kpi.ThresholdType = true; // 0 değer, 1 yüzde
                kpi.Period ='Y';
                kpi.Unit = "adet";
                kpi.Direction = true;
                kpi.CreationDate = DateTime.Now;

                dc.KPIs.InsertOnSubmit(kpi);
                dc.SubmitChanges();

                return kpi.Name;
            }
        }

        public static string GetKpi()
        {
            using (SAKADataDataContext dc = new SAKADataDataContext())
            {
                var list = dc.KPIs.Where(x => x.Name == "Ciro").Select(c => new { c.ID, c.Target, c.Name, c.Threshold}).ToList();

                var KpiList = new List<DTO_ScoreCard>();

                foreach (var k in list)
	            {
		            var item = new DTO_ScoreCard();
                    item.NAME = k.Name;
                    
                    list.Add(item);                    
	            }

                return KpiList.ToArray();
            }

            
        }
        }
    }
}
