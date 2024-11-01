using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Week4_Closing_Project
{
    public class Bilgisayar : BaseMakine
    {
        public int UsbGiris
        {
            get
            {
                return UsbGiris;
            }
            set
            {
                if (UsbGiris != 2 || UsbGiris != 4)
                {
                    Console.WriteLine("Sadece 2 ve 4 atanabilir.");
                    value = -1;
                }
            }
        }

        public bool bluetooth { get; set; }

        public override void Yazdır()
        {
            Console.WriteLine($"Bilgisayarın Üretim Tarihi ----> {ÜretimTarihi}\r\nBilgisayarın SeriNumarası ----> {SeriNumarası}\r\nBilgisayarın Adı ---> {Ad}\r\nBilgisayarın Açıklaması ----> {Açıklama}\r\nBilgisayarın İşletim Sistemi {İşletimSistemi}\r\nUSB Giriş Sayısı ----> {UsbGiris}\r\nBluetooth ----> {(bluetooth ? "VAR" : "YOK")}");
        }
    }
}