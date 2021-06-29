using System;

namespace recursive_extension_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // rekürsif - Öz yinelemeli

            int result = 1;
            for (int i = 1; i < 5; i++)
            {
                result = result * 3;
            }

            Console.WriteLine(result);

            İslemler instance = new();
            Console.WriteLine(instance.Expo(3,4));


            // Extension Metotlar

            string ifade = "Berk";
            bool sonuc = ifade.CheckSpaces();
            Console.WriteLine(ifade.CheckSpaces());

            if(sonuc)
            {
                Console.WriteLine(ifade.RemoveWhiteSpaces());
            }
            Console.WriteLine(ifade.MakeUpperCase());


            int[] arr = {9,3,6,2,1,5,0};
            arr.SortArray();


            int num = 5;
            Console.WriteLine(num.isEvenNumber());
            Console.WriteLine(ifade.GetFirstChar());
            

        }
    }

    public class İslemler{

        public int Expo(int sayi, int us)
        {
            if(us < 2){
                return sayi;
            }
            return Expo(sayi, us-1) * sayi;
        }
        // Expo(3,4)
        // Expo(3,3)*3
        // Expo(3,2)*3*3
        // Expo(3,1)*3*3*3
        // 3*3*3*3 = 3^4


    }

    public static class Extension
    {
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }

        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("*",dizi);
        }

        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }
        public static string MakeLowerCase(this string param)
        {
            return param.ToLower();
        }

        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }

        public static void EkranaYazdir(this int[] param)
        {
            foreach (int item in param)
            {
                Console.WriteLine(item);
            }
        }

        public static bool isEvenNumber(this int param)
        {
            return param % 2 == 0;
        }

        public static string GetFirstChar(this string param)
        {
            return param.Substring(0,1);
        }
    }
}
