using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAKA.DTO
{
     public class DTO_ScoreCard
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Target { get; set; }
        public decimal Threshold { get; set; }

        public DTO_ScoreCard(int id, string name, decimal target, decimal threshold)
        {
            ID = id;
            Name = name;
            Target = target;
            Threshold = threshold;
        }
    }
}
