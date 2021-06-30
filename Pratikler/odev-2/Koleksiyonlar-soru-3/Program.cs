using System;
using System.Collections;
using System.Collections.Generic;
namespace Koleksiyonlar_soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> vowelList = new List<char>{'a', 'e', 'ı','i', 'o','ö', 'u','ü','A','E','I','İ','O','Ö','U','Ü'};
            Console.WriteLine("Lütfen bir cümle yazınız. ");
            string str = Console.ReadLine();

            char[] c = str.ToCharArray();

            ArrayList arr = new ArrayList(c);
            List<char> vowelChars = new List<char>();
            foreach(char x in arr){
                if(vowelList.Contains(x)){
                    vowelChars.Add(x);
                }
            }
            foreach(var i in vowelChars){
                Console.WriteLine(i);
            }

           

        }
    }
}
