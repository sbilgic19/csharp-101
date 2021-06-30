using System;

namespace inheritance
{
    public class Bitkiler:Canlilar // defaultta privatettır. public diye belirtilmeli
    {
        protected void Fotosentez(){
            Console.WriteLine("Bitkiler fotosentez yapar.");
        }

        public override void UyaranlaraTepki(){
            //base.UyaranlaraTepki();
            Console.WriteLine("Bitkiler güneşe tepki verir");
        }
       

        
    }

    public class TohumluBitkiler:Bitkiler
    {
        public TohumluBitkiler(){
            base.Fotosentez();
            base.Beslenme();
            base.UyaranlaraTepki();
        }
        public void TohumlaCogalma(){
            Console.WriteLine("Tohumlu bitkiler tohumlu çoğalır");
        }
    }
    public class TohumsuzBitkiler:Bitkiler
    {
        public TohumsuzBitkiler(){
            base.Fotosentez();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
        }
        public void TohumsuzCogalma(){
            Console.WriteLine("Tohumsuz bitkiler sporla çoğalabilir");
        }
    }
}