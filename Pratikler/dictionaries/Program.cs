using System;
using System.Collections.Generic;

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {   
           
            Dictionary<int,string> kullanicilar= new Dictionary<int, string>();
            kullanicilar.Add(10, "Ayşe Yılmaz");
            kullanicilar.Add(12, "Ahmet Yılmaz");
            kullanicilar.Add(18, "Deniz Arda");
            kullanicilar.Add(20, "Özcan Coşar");

            // Dizinin elemanlarına erişim

            Console.WriteLine("***** Elemanlara Erişim *****");
            Console.WriteLine(kullanicilar[12]);

            foreach(var item in kullanicilar)
                Console.WriteLine(item);
           
            Console.WriteLine(kullanicilar.Count);

            // Contains
            Console.WriteLine(kullanicilar.ContainsKey(12));
            Console.WriteLine(kullanicilar.ContainsValue("Brk"));


            // Remove

            Console.WriteLine(kullanicilar.Remove(12));
            foreach(var item in kullanicilar)
                Console.WriteLine(item);

            // keys, value

            foreach(var i in kullanicilar){
                Console.WriteLine(i.Key);
                Console.WriteLine(i.Value);
            }

            foreach(var x in kullanicilar.Keys)
                Console.WriteLine(x);

            foreach(var x in kullanicilar.Values)
                Console.WriteLine(x);



           


            

        }
    }
}
