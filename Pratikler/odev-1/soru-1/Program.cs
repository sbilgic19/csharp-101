using System;
using System.Collections.Generic;

namespace soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Bir konsol uygulamasında kullanıcıdan pozitif bir sayı
                girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif
                sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan
                çift olanlar console'a yazdırın.
            */

            Console.WriteLine("Lütfen pozitif bir sayı giriniz: ");
            int tekrar = Convert.ToInt32(Console.ReadLine());

            List<int> arr = new();
            for(int i=0; i<tekrar; i++)
            {
                Console.WriteLine("Lütfen pozitif sayı giriniz: ");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number % 2==0)
                {
                    arr.Add(number);
                }
            }

            Console.WriteLine("Girilen sayılardan çift olanlar...");
            foreach (int num in arr)
            {
                Console.WriteLine(num);
            }



        }
    }
}
