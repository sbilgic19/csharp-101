using System;
using System.Collections.Generic;

namespace generic_collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<T> class
            // System.Collections.Generic
            // T -> object türündedir

            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(2);
            sayiListesi.Add(4);
            sayiListesi.Add(34);
            sayiListesi.Add(92);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("mavi");
            renkListesi.Add("sarı");
            renkListesi.Add("kırmızı");
            renkListesi.Add("turuncu");
            renkListesi.Add("yeşil");


            Console.WriteLine(renkListesi.Count);

            foreach(var item in sayiListesi)
            {
                Console.WriteLine(item);
            }

            foreach(var renk in renkListesi)
            {
                Console.WriteLine(renk);
            }

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));


            // Listeden eleman çıkarma

            sayiListesi.Remove(4);
            renkListesi.Remove("yeşil");

            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);


            // Liste içerisinde arama

            if(sayiListesi.Contains(10)){
                Console.WriteLine("Listede bulunuyor");
            }

            // Eleman ile indekse erişim

            renkListesi.BinarySearch("sarı");

            // Diziyi Liste'ye çevirme

            string[] hayvanlar = {"kedi","köpek","kuş"};

            List<string> hayvanListesi = new List<string>(hayvanlar);

            // Listeyi temizleme

            hayvanListesi.Clear();


            // List içerisinde nesne tutma

            List<Kullanıcılar> kullanıcıListesi = new List<Kullanıcılar>();
            Kullanıcılar kullanici1 = new Kullanıcılar();
            kullanici1.Isim = "Ayşe";
            kullanici1.Soyisim = "Yılmaz";
            kullanici1.Yas = 20;

            Kullanıcılar kullanici2 = new Kullanıcılar();
            kullanici2.Isim = "Özcan";
            kullanici2.Soyisim = "Yılmaz";
            kullanici2.Yas = 26;

            kullanıcıListesi.Add(kullanici1);
            kullanıcıListesi.Add(kullanici2);


            List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();
            yeniListe.Add(new Kullanıcılar(){
                Isim = "Deniz",
                Soyisim = "Arda",
                Yas = 24
            });

            foreach(var kullanici in kullanıcıListesi){
                Console.WriteLine("Kullanıcı adı: "+kullanici.Isim);
                Console.WriteLine("Kullanıcı soyadı: "+kullanici.Soyisim);
                Console.WriteLine("Kullanıcı yaşı: "+kullanici.Yas);


            }
            yeniListe.Clear();

        }
    }

    public class Kullanıcılar{
        private string isim;
        private string soyisim;
        private int yas;

        public string Isim{get => isim; set => isim = value;}
        public string Soyisim{get => soyisim; set => soyisim = value;}
        public int Yas{get => yas; set => yas = value;}
    }
}
