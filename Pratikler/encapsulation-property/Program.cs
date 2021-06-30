using System;

namespace encapsulation_property
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Ogrenci ogrenci1 = new Ogrenci();

            // get setten dolayı bu şekilde yapabiliyoruz.
            ogrenci1.Isim = "Ayşe";
            ogrenci1.Soyisim = "Yılmaz";
            ogrenci1.OgrenciNo = 291;
            ogrenci1.Sinif = 3;
            
            ogrenci1.OgrenciBilgileri();

            ogrenci1.SinifAtlat();
            ogrenci1.OgrenciBilgileri();
            
            Console.WriteLine("***** Sınıf Düşürme Örneği *****");
            Ogrenci ogrenci2 = new Ogrenci("Deniz","Arda",256,1);
            ogrenci2.OgrenciBilgileri();

            ogrenci2.SinifDusur();
            ogrenci2.SinifDusur();
            ogrenci2.OgrenciBilgileri();
            




        }
    }

    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sinif;

        public Ogrenci(string isim, string soyisim, int ogrenciNo, int sinif)
        {
            Isim= isim;
            Soyisim= soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }
        public Ogrenci()
        {

        }

        public string Isim
        { 
            get {return isim;} 
            set {isim = value;} 
        }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif
        { 
            get => sinif;
            set
            {
                if(value < 1)
                {
                    Console.WriteLine("Sınıf en az 1 olabilir.");
                    sinif = 1;
                }
                else
                    sinif = value;
            }
        }

        public void OgrenciBilgileri(){
            Console.WriteLine("Öğrenci Adı: {0} ",isim);
            Console.WriteLine("Öğrenci Soyadı: {0} ",soyisim);
            Console.WriteLine("Öğrenci No'su: {0} ",ogrenciNo);
            Console.WriteLine("Öğrencinin Sınıfı: {0} ",sinif);
            Console.WriteLine();
        }

        public void SinifAtlat(){
            this.Sinif += 1;
        }
        public void SinifDusur(){
            this.Sinif = this.Sinif - 1;
        }
        
    }
}
