using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
          
            // dizi tanımlama

            string[] renkler = new string[5];
            string[] hayvanlar = {"köpek","kedi","kuş"};

            int[] array;
            array = new int[5];

            renkler[0] = "mavi";
            Console.WriteLine(hayvanlar[0]);

            renkler[1] = "sarı";
            array[3] = 10;

            Console.WriteLine(array[3]);
            Console.WriteLine(renkler[0]);


            // döngülerle dizi kullanımı
            
            Console.WriteLine("Lütfen dizinin eleman sayısını giriniz. ");

            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayıDizisi = new int[diziUzunlugu];


            for (int i=0; i<diziUzunlugu; i++){
                Console.Write("Lütfen {0}. sayısı giriniz. ", i+1);
                sayıDizisi[i] = int.Parse(Console.ReadLine());
            }

            int toplam = 0;
            foreach (var sayi in sayıDizisi)
            {
                toplam += sayi;
            }

            Console.WriteLine("Ortalamam : "+toplam/diziUzunlugu);

            






        }
    }
}
