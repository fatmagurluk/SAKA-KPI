using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAKA.DTO
{
     public class DTO_ScoreCard
    {
         // EKRANA BASTIRMAK İSTEDİĞİMİZ VERİLER YAZILDI
         // period dediği gün ay yıl şeklinde 3 değer aldığımız için enum oluşturulacak
         // statu bunun son drum olan kırmızı sayı yeşil değerleri alıyor

     
        public string NAME { get; set; }
        public decimal VALUE { get; set; }
         public string UNIT { get; set; } // dolar mı adetmi onlar
         public DateTime DATE { get; set; }
         public Period PERIOD { get; set; }
         public Statu STATU { get; set; }

    }
}
