using System;

namespace inheritance
{
    public class Hayvanlar:Canlilar
    {
        protected void Adaptasyon(){
            Console.WriteLine("Hayvanlar adapte olur.");
        }

        public override void UyaranlaraTepki(){
            base.UyaranlaraTepki();
            Console.WriteLine("Hayvanlar temasa tepki verir");
        }

        
    }

    public class Surungenler:Hayvanlar{
        public Surungenler(){
            base.Adaptasyon();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
        }

        public void SurunerekHareket(){
            Console.WriteLine("Sürüngenler sürünerek hareket eder.");
        }
    }
    public class Kuslar: Hayvanlar
    {
        public Kuslar(){
            base.Adaptasyon();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
            base.UyaranlaraTepki();
        }
        public void Ucmak(){
            Console.WriteLine("Kuşlar uçar.");
        }
    }
}