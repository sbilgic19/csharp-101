using System;

namespace soru_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Bir konsol uygulamasında kullanıcıdan bir cümle yazmasını
                isteyin. Cümledeki toplam kelime ve harf sayısını console'a 
                yazdırın.

            */

            Console.WriteLine("Lütfen bir cümle yazınız: ");
            string str = Console.ReadLine();

            string[] arr = str.Split(" ");

            int kelimeSayisi = arr.Length;
            
            int ToplamHarfSayisi = 0;
            foreach(string s in arr)
            {
                ToplamHarfSayisi += s.Length;
            }

            Console.WriteLine("Toplam kelime sayısı: {0} - Toplam harf sayısı: {1}",kelimeSayisi,ToplamHarfSayisi);
        }
    }
}
