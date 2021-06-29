using System;
using System.Collections.Generic;

namespace soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Bir konsol uygulamasında kullanıcıdan pozitif iki sayı 
                girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet 
                pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu 
                sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
            */

            Console.WriteLine("Lütfen bir kez ENTER'a basarak pozitif iki sayı giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());

            List<int> arr = new();
            for (int i=0; i<n; i++){
                Console.WriteLine("Lütfen bir sayı giriniz");
                int num = Convert.ToInt32(Console.ReadLine());
                if(num%m==0){
                    arr.Add(num);
                }
            }
            
            Console.WriteLine("Girmiş olduğunuz sayılardan {0}'e tam bölünenler yazdırılıyor... ",m);
            foreach (var i in arr){
                Console.WriteLine(i);
            }

            
        }
    }
}
