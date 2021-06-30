using System;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //                           Canlılar
            //                |                              |
            //             Bitkiler                       Hayvanlar
            //      |                    |            |               |
            // TohumluBitkiler    TohumsuzBitkiler  Sürüngen       Kuşlar


            TohumluBitkiler tohumluBitki = new TohumluBitkiler();
            tohumluBitki.TohumlaCogalma();

            Console.WriteLine("*************");
            Kuslar marti = new Kuslar();
            marti.Ucmak();


        }
    }
}
