using System;

namespace datetime_math_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);


            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);


            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());



            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddSeconds(3));
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine(DateTime.Now.AddYears(10));
            Console.WriteLine(DateTime.Now.AddMilliseconds(100));


            // DateTime Format

            Console.WriteLine(DateTime.Now.ToString("dd")); // 30
            Console.WriteLine(DateTime.Now.ToString("ddd")); // Wed
            Console.WriteLine(DateTime.Now.ToString("dddd")); // Wednesday


            Console.WriteLine(DateTime.Now.ToString("MM")); // 06
            Console.WriteLine(DateTime.Now.ToString("MMM")); // Jun
            Console.WriteLine(DateTime.Now.ToString("MMMM")); // June


            Console.WriteLine(DateTime.Now.ToString("yy")); // 21
            Console.WriteLine(DateTime.Now.ToString("yyyy")); // 2021
            

            Console.WriteLine("***** Math Kütüphanesi *****");
            // Math Kütüphanesi

            Console.WriteLine(Math.Abs(-25));
            Console.WriteLine(Math.Sin(10));
            Console.WriteLine(Math.Cos(10));
            Console.WriteLine(Math.Tan(10));

            Console.WriteLine(Math.Ceiling(10.254789)); // 11
            Console.WriteLine(Math.Round(10.254)); // 10
            Console.WriteLine(Math.Floor(10.254789)); // 10


            Console.WriteLine(Math.Max(2,6));
            Console.WriteLine(Math.Min(2,6));


            Console.WriteLine(Math.Pow(3,4));
            Console.WriteLine(Math.Sqrt(3));
            

            





            

















        }
    }
}
