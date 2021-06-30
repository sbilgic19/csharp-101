using System;

namespace structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen d1 = new Dikdortgen();
            d1.kisaKenar = 3;
            d1.uzunKenar = 5;

            Console.WriteLine("Class Alan Hesapla: {0} ",d1.AlanHesapla());


            Console.WriteLine("***** Struct *****");
            Dikdortgen_Struct d2 = new Dikdortgen_Struct();
            // d2.kisaKenar = 3;
            // d2.uzunKenar = 5;
            Console.WriteLine("Class Alan Hesapla: {0} ",d2.AlanHesapla());

            


        }
    }

    class Dikdortgen
    {
        public int kisaKenar;
        public int uzunKenar;
        public long AlanHesapla()
        {
            return this.kisaKenar * this.uzunKenar;
        }

        public Dikdortgen(){
            kisaKenar = 3;
            uzunKenar = 5;
        }
    }

    struct Dikdortgen_Struct
    {
        public int kisaKenar;
        public int uzunKenar;
        public long AlanHesapla()
        {
            return this.kisaKenar * this.uzunKenar;
        }
        public Dikdortgen_Struct(int kisaKenar, int uzunKenar){
            this.kisaKenar = kisaKenar;
            this.uzunKenar = uzunKenar;
        }
    }
}
