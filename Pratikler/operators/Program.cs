using System;

namespace operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Atama ve işlemli atama

            /*
            int x = 3;
            int y = 3;

            y = y+2;
            y += 2;

            y /= 3;

            Console.WriteLine(y);

            */


            bool isSuccess = true;

            bool isComplete = false;

            if(isComplete){
                Console.WriteLine("Perfect!");
            }

            if (isComplete || isComplete){
                Console.WriteLine("Great!");
            }

            if (isSuccess && isComplete){
                Console.WriteLine("Fine");
            }
            
            
            // İlişkisel Operatörler

            int a = 3;
            int b = 4;

            bool sonuc = a < b;

            Console.WriteLine(sonuc);

            sonuc = a > b;
            sonuc = a >= b;
            sonuc = a <= b;
            sonuc = a == b;


            // Aritmetik Operatörler

            // *, +, -, /, %

            int sayi1 = 10;
            int sayi2 = 5;

            int sonuc1 = sayi1 / sayi2;
            sonuc1 = sayi1 * sayi2;
            sayi1 ++;


            int sonuc2 = 20 % 3;


            
            


            




        }
    }
}
