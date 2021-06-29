using System;

namespace method_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
           

            // out parametreler 
            string sayi = "999";
            boolean sonuc = int.TryParse(sayi,out int outSayi);

            if(sonuc){
                Console.WriteLine("Başarılı");
                Console.WriteLine(outSayi);
            }else{
                Console.WriteLine("Başarısız");
            }


            Metotlar instance = new Metotlar();
            int toplamSonucu;
            instance.Topla(2,3, out toplamSonucu);
            Console.WriteLine(toplamSonucu);

            int ifade = 999;
            instance.EkranaYazdir(Convert.ToString(ifade));
            instance.EkranaYazdir(ifade);


            // Metot İmzası
            // MetotAd + parametre sayısı + parametre
        }
    }

    class Metotlar
    {
        public int Topla(int a, int b, out int toplam)
        {
            toplam = a+b;
        }

        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(string veri1, string veri2)
        {
            Console.WriteLine(veri1 + veri2);
        }

    }
}
