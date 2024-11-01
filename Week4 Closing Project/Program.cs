using Week4_Closing_Project;

bool bitir = true;
while (bitir)
{
    Console.WriteLine("Telefon Üretmek için 1 || Bilgisayar üretmek için 2'ye basınız.");
    string cevap = Console.ReadLine();

    if (cevap == "1")
    {
        Console.WriteLine("Telefon Üretmeyi seçtiniz");
        Console.WriteLine("---------------------------");
        Console.WriteLine("Telefon Üretiliyor......");
        Telefon telefon = new Telefon();
        Console.WriteLine("---------------------------");
        Console.Write("Seri Numarası ----> ");
        telefon.SeriNumarası = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("---------------------------");
        Console.Write("Ad ----> ");
        telefon.Ad = Console.ReadLine();
        Console.WriteLine("---------------------------");
        Console.Write("Açıklama ----> ");
        telefon.Açıklama = Console.ReadLine();
        Console.WriteLine("---------------------------");
        Console.Write("İşletim Sistemi ----> ");
        telefon.İşletimSistemi = Console.ReadLine();
        Console.WriteLine("---------------------------");
        Console.Write("Telefonunuz Türkiye Lisanslı mı? (Evet/Hayır) ");
        string LisansCevap = Console.ReadLine().ToLower();
        telefon.Lisans = LisansCevap == "evet";
        Console.WriteLine("---------------------------");
        telefon.Yazdır();
    }

    else if (cevap == "2")
    {
        Console.WriteLine("Bilgisayar Üretmeyi seçtiniz");
        Console.WriteLine("---------------------------");
        Console.WriteLine("Bilgisayar Üretiliyor......");
        Bilgisayar bilgisayar = new Bilgisayar();
        Console.WriteLine("---------------------------");
        Console.Write("Seri Numarası ----> ");
        bilgisayar.SeriNumarası = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("---------------------------");
        Console.Write("Ad ----> ");
        bilgisayar.Ad = Console.ReadLine();
        Console.WriteLine("---------------------------");
        Console.Write("Açıklama ----> ");
        bilgisayar.Açıklama = Console.ReadLine();
        Console.WriteLine("---------------------------");
        Console.Write("İşletim Sistemi ----> ");
        bilgisayar.İşletimSistemi = Console.ReadLine();
        Console.WriteLine("---------------------------");
        Console.WriteLine("Kaç tane USB girişi var? Seçeneklerin (2 - 4)");
        ((Bilgisayar)bilgisayar).UsbGiris = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("---------------------------");
        Console.Write("Bluetooth Varmı? (True/False) ");
        string BluetoothCevap = Console.ReadLine().ToLower();
        bilgisayar.bluetooth = BluetoothCevap == "evet";
        Console.WriteLine("---------------------------");
        bilgisayar.Yazdır();
        Console.WriteLine("Başarıyla Üretildi..");
    }
    else
    {
        Console.WriteLine("Hatalı Seçim Yaptınız lütfen 1 veya 2 giriniz");
    }

    Console.WriteLine("Başka bir ürün üretmek ister misiniz? (evet/hayır)");
    bitir = Console.ReadLine().ToLower() == "evet";
}