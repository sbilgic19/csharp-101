using System;
using System.Collections;
using System.Collections.Generic;

namespace Proje_2
{
    class Board  
    {
        private static List<Kart> kartlar = new();

        internal static List<Kart> Kartlar { get => kartlar; set => kartlar = value; }

        public void BoardGoruntule(){
            Console.WriteLine("TODO Line");
            Console.WriteLine("************************");
            foreach(var k in Kartlar){
                if((int)k.Line == 1){
                    Console.WriteLine("Başlık         :{0}\nİçerik         :{1}\nAtanan Kişi    :{2}\nBüyüklük       :{3}\n-\n",k.Baslik,k.Icerik,k.AtananKisiId,k.KartBuyuklugu);
                }
            }
            Console.WriteLine("IN PROGRESS Line");
            Console.WriteLine("************************");
            foreach(var k in Kartlar){
                if((int)k.Line == 2){
                    Console.WriteLine("Başlık         :{0}\nİçerik         :{1}\nAtanan Kişi    :{2}\nBüyüklük       :{3}\n-\n",k.Baslik,k.Icerik,k.AtananKisiId,k.KartBuyuklugu);
                }
            }
            Console.WriteLine("DONE Line");
            Console.WriteLine("************************");
            foreach(var k in Kartlar){
                if((int)k.Line == 3){
                    Console.WriteLine("Başlık         :{0}\nİçerik         :{1}\nAtanan Kişi    :{2}\nBüyüklük       :{3}\n-\n",k.Baslik,k.Icerik,k.AtananKisiId,k.KartBuyuklugu);
                }
            }
        }

        public static bool KartArama(string kartBasligi){
           foreach(var k in Kartlar){
               if(k.Baslik == kartBasligi){
                   return true;
               }
           }
           return false;
        }

        public static void KartSil(string kartBasligi){
            try{
                foreach(var k in Kartlar){
                    if(kartBasligi == k.Baslik){
                        kartlar.Remove(k);
                        return;
                    }
                }
            }catch(Exception ex){
                Console.WriteLine("Bir hatayla karşılaşıldı: Detaylı bilgi {0}",ex);
            }
            
        }

        public static void KartGoruntule(string kartBasligi){
           foreach(var k in Kartlar){
                if(k.Baslik == kartBasligi){
                    Console.WriteLine("Başlık         :{0}\nİçerik         :{1}\nAtanan Kişi    :{2}\nBüyüklük       :{3}\nLine: {4}\n",k.Baslik,k.Icerik,k.AtananKisiId,k.KartBuyuklugu,k.Line);
                }
            }
        }

        public static Kart KartiVer(string kBaslik){
            foreach(var l in Kartlar){
                if(l.Baslik == kBaslik){
                    return l;
                }
            }
            return null;
        }

        public static bool buKisiyeKartAtılmışMı(int id){
            foreach(var k in Kartlar){
                if(k.AtananKisiId == id){
                    return true;
                }
            }
            return false;
        }






    }





}