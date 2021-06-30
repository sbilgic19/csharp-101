using System;

namespace interface_sample
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("********** Interface **********");
            Console.WriteLine();
            
            Focus focus = new Focus();
            Console.WriteLine(focus.HangiMarka().ToString());
            Console.WriteLine(focus.KacTekerlek().ToString());
            Console.WriteLine(focus.StandartRengi().ToString());

            Console.WriteLine();

            Civic civic = new();
            Console.WriteLine(civic.HangiMarka().ToString());
            Console.WriteLine(civic.KacTekerlek().ToString());
            Console.WriteLine(civic.StandartRengi().ToString());

            Console.WriteLine();

            Corolla corolla = new();
            Console.WriteLine(corolla.HangiMarka().ToString());
            Console.WriteLine(corolla.KacTekerlek().ToString());
            Console.WriteLine(corolla.StandartRengi().ToString());

            Console.WriteLine();
            Console.WriteLine("********** Abstract **********");
            Console.WriteLine();

            NewFocus f1 = new();
            Console.WriteLine(f1.HangiMarka().ToString());
            Console.WriteLine(f1.KacTekerlek().ToString());
            Console.WriteLine(f1.StandartRengi().ToString());

            Console.WriteLine();

            NewCivic c1 = new();
            Console.WriteLine(c1.HangiMarka().ToString());
            Console.WriteLine(c1.KacTekerlek().ToString());
            Console.WriteLine(c1.StandartRengi().ToString());
        }
    }
}
