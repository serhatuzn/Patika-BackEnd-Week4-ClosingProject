using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Week4_Closing_Project
{
    public class Telefon : BaseMakine
    {
        public bool Lisans { get; set; }

        public override void Yazdır()
        {
            Console.WriteLine($"Telefonun Üretim Tarihi ----> {ÜretimTarihi}\r\nTelefonun SeriNumarası ----> {SeriNumarası}\r\nTelefonun Adı ---> {Ad}\r\nTelefonun Açıklaması ----> {Açıklama}\r\nTelefonun İşletim Sistemi {İşletimSistemi}\r\nTelefonun Lisansı {Lisans}");
        }
    }
}