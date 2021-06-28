﻿using System;

namespace type_conversions
{
    class Program
    {
        static void Main(string[] args)
        {
            
           // Implicit Conversion

            /*
            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a+b+c;
            Console.WriteLine("d: "+d);
            long h = d;
            Console.WriteLine("h: "+h);

            float f = h;

            Console.WriteLine();

            string e = "hello";
            char x = 'k';
            object g = e+x+f;
            Console.WriteLine(g);


            */


            



           // Explicit Conversion 

            Console.WriteLine("***** Explicit Conversion *****");
            int x = 4;
            byte y = (byte) x;

            Console.WriteLine("y: "+y);

            int z = 100;
            byte t = (byte) z;

            Console.WriteLine("t: "+t);


            float w = 10.3f;
            byte v = (byte) w;
            Console.WriteLine(v);


            // ***** ToString *****


            Console.WriteLine("***** ToString Methodu *****");
            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy: "+yy);


            string zz = 12.5f.ToString();
            Console.WriteLine("zz: "+ zz);


            // System.Convert

            Console.WriteLine("***** System.Convert Sınıfı *****");
            

            string s1 = "10", s2 = "20";

            int sayi1 , sayi2;
            int toplam;


            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);

            toplam = sayi1 + sayi2;

            Console.WriteLine("Toplam: "+toplam);



            // ParseMethod

            ParseMethod();






        }

        public static void ParseMethod()
        {
            string metin1 = "10";
            string metin2 = "10.25";
            int rakam1;
            double double1;

            double1 = Double.Parse(metin2); // Parse her zaman string alır.
            rakam1 = Int32.Parse(metin1);
            Console.WriteLine("rakam1: "+rakam1);
            Console.WriteLine("double: "+double1);




        }
    }
}
