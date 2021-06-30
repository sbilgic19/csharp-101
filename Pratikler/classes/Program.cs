using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // * Public
            // * Private ->
            // * Internal -> sadece kendi bulunduğu proje içerisinde erişilebilir.
            // * Protected -> kendi bulunduğu paket ve inherit edenlerden erişileiblir.


            Calisan calisan1 = new Calisan();
            calisan1.isim = "Ayşe";
            calisan1.soyisim = "Kara";
            calisan1.no = 535777;
            calisan1.department = "İnsan Kaynakları";

            calisan1.CalisanBilgileri();

            Calisan calisan2 = new Calisan();
            calisan2.isim = "Efe";
            calisan2.soyisim = "Arda";
            calisan2.no = 003777;
            calisan1.department = "Satınalma";
            calisan2.CalisanBilgileri();

        }
    }

    class Calisan
    {
        public string isim;
        public string soyisim;
        public int no;
        public string department;

        public void CalisanBilgileri(){
            Console.WriteLine("Çalışan Adı: {0} ",isim);
            Console.WriteLine("Çalışan Soyadı: {0} ",soyisim);
            Console.WriteLine("Çalışan Numarası: {0} ",no);
            Console.WriteLine("Çalışan Departmanı: {0} ",department);
            Console.WriteLine();
        }

    }
}
