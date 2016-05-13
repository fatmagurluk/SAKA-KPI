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

        public static void getScoreCard()
        {
            var list = new List<DTO_ScoreCard>();

            var scorecard = new DTO_ScoreCard[]
            {
                new DTO_ScoreCard(1,"kaza", 20, 2),
                new DTO_ScoreCard(2, "benzin", 1500, 50)
            };

            list.AddRange(scorecard);
        }
    }
}
