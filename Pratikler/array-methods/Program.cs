using System;

namespace array_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] sayiDizisi = {23,12,86,11,3,17,72,37};

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            Array.Sort(sayiDizisi);
            Console.WriteLine("Sıralı Sayı Dizisi");

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            // Clear

            Console.WriteLine("*** Array Clear ***");

            Array.Clear(sayiDizisi,2,2); // 2.indeksten başlayarak 2 tane elemanı 0'lar.
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }


            // Reverse

            Console.WriteLine("*** Array Reverse ***");
            Array.Reverse(sayiDizisi);


            // IndexOf

            Console.WriteLine(Array.IndexOf(sayiDizisi, 23));


            // Resize

            Array.Resize<int>(ref sayiDizisi, 11);

            sayiDizisi[9] = 99;

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }




            
            



        }
    }
}
