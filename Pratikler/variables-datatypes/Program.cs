using System;

namespace variables_datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int deger;
            deger = 2;

            string degisken = null;

            byte b = 5; // 1 byte
            sbyte c = 5; // 1 byte

            short s = 5; // 2 byte
            ushort us = 5; // 2 byte

            Int16 i16 = 2; // 2byte
            int i = 2; // 4byte
            Int32 i32 = 2;  // 4 byte
            Int64 i64 = 2;  // 8 byte

            float f = 5; // 4 byte

            double d = 5; // 8 byte


            char ch = '2'; // 2 byte
            string str = "Yes!"; // sınırsız

            bool b1 = true;

            DateTime dt = DateTime.Now;

            
            object o1 = "x";
            object o2 = "y";
            object o3 = 4;
            object o4 = 4.3;

            string str1 = string.Empty;

            string ad = "John";
            string soyad = "Doey";

            string tamIsım = ad+ " "+ soyad;


            bool b4 = 10 < 3;

            int int20 = 20;
            string str20 = "20";

            int int21 = int20 + Convert.ToInt32(str20);
            string yenideger = str20 + int20.ToString();



            int int22 = int20 + int.Parse(str20);

            string dt1 = DateTime.Now.ToString("dd.MM.yyyy");
            string dt2 = DateTime.Now.ToString("dd/MM/yyyy");
            string dt3 = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(dt3);




        }
    }
}
