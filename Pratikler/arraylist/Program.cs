using System;
using System.Collections;
using System.Collections.Generic;
namespace arraylist
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList liste = new ArrayList();

            liste.Add("Ayşe");
            liste.Add(2);
            liste.Add(true);
            liste.Add('A');

            Console.WriteLine(liste[1]);

            foreach(var i in liste)
            {
                Console.WriteLine(i);
            }

            // AddRange
            Console.WriteLine("***** AddRange *****");
            string[] renkler = {"kırmızı","sarı","yeşil"};
            List<int> sayilar = new List<int>(){1,0,3,7,5,9};
            
            liste.AddRange(sayilar);
            liste.AddRange(renkler);

            foreach(var item in liste)
                Console.WriteLine(item);

            // Sort

            // liste.Sort(); // Hata verir

            // BinarySearch

            Console.WriteLine("***** BinarySearch *****");
            Console.WriteLine(liste.BinarySearch(9));

            // Reverse

            liste.Reverse();

            foreach(var item in liste)
                Console.WriteLine(item);

            // Clear

            liste.Clear();
            

        }
    }
}
