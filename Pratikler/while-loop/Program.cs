using System;

namespace while_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir sayı giriniz. ");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac <= sayi){
                toplam += sayac;
                sayac ++;
            }

            Console.WriteLine("Ortalama: "+toplam/sayi);

            char character = 'a';
            while(character < 'z'){
                Console.WriteLine(character);
                character ++;
            }

            string[] arabalar = {"BMW","Ford","Toyota","Nissan"};
            foreach(var item in arabalar)
            {
                Console.WriteLine(item);

            }


        }
    }
}
