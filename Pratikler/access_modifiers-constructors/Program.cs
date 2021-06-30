using System;

namespace access_modifiers
{
    class Program
    {
        static void Main(string[] args)
        {
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

            Calisan calisan3 = new Calisan("Mehmet","Yılmaz",57325,"IT");
            calisan3.CalisanBilgileri();

            Calisan calisan4 = new Calisan("Ali","Mert");
            calisan4.CalisanBilgileri();
        }
    }
    class Calisan
    {

        public string isim;
        public string soyisim;
        public int no;
        public string department;

        public Calisan()
        {

        }
        public Calisan(string isim, string soyisim){
            this.isim = isim;
            this.soyisim = soyisim;
        }
        public Calisan(string isim, string soyisim, int no, string department){
            this.isim = isim;
            this.soyisim= soyisim;
            this.no = no;
            this.department = department;

        }
        public void CalisanBilgileri(){
            Console.WriteLine("Çalışan Adı: {0} ",isim);
            Console.WriteLine("Çalışan Soyadı: {0} ",soyisim);
            Console.WriteLine("Çalışan Numarası: {0} ",no);
            Console.WriteLine("Çalışan Departmanı: {0} ",department);
            Console.WriteLine();
        }

    }
}
