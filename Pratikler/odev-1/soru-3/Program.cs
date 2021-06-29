using System;
using System.Collections.Generic;

namespace soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Bir konsol uygulamasında kullanıcıdan pozitif bir sayı 
                girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime 
                girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri 
                sondan başa doğru console'a yazdırın.
            */

            Console.WriteLine("Lütfen pozitif bir sayı giriniz: ");
            int number = Convert.ToInt32(Console.ReadLine());

            List<string> arr = new();
            for (int i = 0; i<number; i++)
            {
                Console.WriteLine("Lütfen yeni bir kelime giriniz: ");
                string str = Console.ReadLine();
                arr.Add(str);
            }
            arr.Reverse();

            Console.WriteLine("Yazdığınız kelimeler tersten yazdırılıyor... ");
            foreach(var i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
