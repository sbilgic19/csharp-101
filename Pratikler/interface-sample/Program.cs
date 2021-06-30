using System;

namespace interface_sample
{
    class Program
    {
        static void Main(string[] args)
        {
            Focus focus = new Focus();
            Console.WriteLine(focus.HangiMarka().ToString());
            Console.WriteLine(focus.KacTekerlek().ToString());
            Console.WriteLine(focus.StandartRengi().ToString());

            Civic civic = new();
            Console.WriteLine(civic.HangiMarka().ToString());
            Console.WriteLine(civic.KacTekerlek().ToString());
            Console.WriteLine(civic.StandartRengi().ToString());

            Corolla corolla = new();
            Console.WriteLine(corolla.HangiMarka().ToString());
            Console.WriteLine(corolla.KacTekerlek().ToString());
            Console.WriteLine(corolla.StandartRengi().ToString());
        }
    }
}
