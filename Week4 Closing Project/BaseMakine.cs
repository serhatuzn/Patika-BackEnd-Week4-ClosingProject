using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Week4_Closing_Project
{
    public class BaseMakine
    {
        public DateTime ÜretimTarihi { get; set; }
        public int SeriNumarası { get; set; }
        public string Ad { get; set; }
        public string Açıklama { get; set; }
        public string İşletimSistemi { get; set; }


        public BaseMakine()
        {
            ÜretimTarihi = DateTime.Now;
        }

        public virtual void Yazdır()
        {
            Console.WriteLine($"Üretim Tarihi ------> {ÜretimTarihi}");
            Console.WriteLine($"Seri Numarası ------> {SeriNumarası}");
            Console.WriteLine($"Ad ------> {Ad}");
            Console.WriteLine($"Açıklama ------> {Açıklama}");
            Console.WriteLine($"İşletim Sistemi ------> {İşletimSistemi}");
        }
    }
}