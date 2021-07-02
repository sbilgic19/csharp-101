using System;
using System.Collections;
using System.Collections.Generic;
namespace Proje_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();

            // Initially assigned
            Kisiler kisi1 = new Kisiler("Ali","Yılmaz");
            Kisiler kisi2 = new Kisiler("Ayşe","Yılmaz");
            Kisiler kisi3 = new Kisiler("Defne","Yılmaz");

            Kisiler kisi4 = new Kisiler("Ahmet","Yılmaz");
            Kisiler kisi5 = new Kisiler("Turan","Yılmaz");
            Kisiler kisi6 = new Kisiler("Yıldız","Yılmaz");

            Kisiler kisi7 = new Kisiler("Barçın","Yılmaz");
            Kisiler kisi8 = new Kisiler("Melisa","Yılmaz");
            Kisiler kisi9 = new Kisiler("Caner","Yılmaz");

            Kisiler kisi10 = new Kisiler("Alp","Yılmaz");
            Kisiler kisi11 = new Kisiler("Berke","Yılmaz");
            Kisiler kisi12 = new Kisiler("Efe","Yılmaz");

            // First Team
            List<Kisiler> takim1Kisiler = new();
            takim1Kisiler.Add(kisi1);
            takim1Kisiler.Add(kisi2);
            takim1Kisiler.Add(kisi3);
            Takim takim1 = new Takim(takim1Kisiler);

            // Second Team
            List<Kisiler> takim2Kisiler = new();
            takim2Kisiler.Add(kisi4);
            takim2Kisiler.Add(kisi5);
            takim2Kisiler.Add(kisi6);
            Takim takim2 = new Takim(takim2Kisiler);

            // Third Team
            List<Kisiler> takim3Kisiler = new();
            takim3Kisiler.Add(kisi7);
            takim3Kisiler.Add(kisi8);
            takim3Kisiler.Add(kisi9);
            Takim takim3 = new Takim(takim3Kisiler);

            // Fourth Team
            List<Kisiler> takim4Kisiler = new();
            takim4Kisiler.Add(kisi10);
            takim4Kisiler.Add(kisi11);
            takim4Kisiler.Add(kisi12);
            Takim takim4 = new Takim(takim4Kisiler);


            Kart k1 = new Kart("Deneme1","test-1",Buyukluk.XL,Line.TODO,kisi1.Id);
            Kart k2 = new Kart("Deneme2","test-2",Buyukluk.XS,Line.TODO,kisi4.Id);
            Kart k3 = new Kart("Deneme3","test-3",Buyukluk.L,Line.InProgress,kisi7.Id);
            Kart k4 = new Kart("Deneme4","test-4",Buyukluk.M,Line.Done,kisi10.Id);


            // Do not assign
            Kisiler kisi13 = new Kisiler("Büşra","Yılmaz");
            Kisiler kisi14 = new Kisiler("Sanem","Yılmaz");
            Kisiler kisi15 = new Kisiler("Mehmet","Yılmaz");
            
           

            
            bool menu = true;
            while(menu){
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
                Console.WriteLine("*******************************************");
                Console.WriteLine("(1) Board Listelemek\n(2) Board'a Kart Eklemek\n(3) Board'dan Kart Silmek\n(4) Kart Taşımak\n\nÇıkış yapmak için 0'a basınız.\n");
                string bas = Console.ReadLine();

                if(bas == "0"){
                    menu = false;
                }else if(bas == "1"){
                    board.BoardGoruntule();
                }else if(bas == "2"){
                    Console.WriteLine("Başlık Giriniz                                  : ");
                    string kBaslik = Console.ReadLine();
                    Console.WriteLine("İçerik Giriniz                                  :");
                    string kIcerik = Console.ReadLine();
                    Console.WriteLine("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  :");
                    string kBuyukluk = Console.ReadLine();
                    Console.WriteLine("Kişi Seçiniz                                    :");
                    int kAtananKisiId = Convert.ToInt32(Console.ReadLine());
                    while(Board.buKisiyeKartAtılmışMı(kAtananKisiId)){
                        Console.WriteLine("Bu kişiye kart atılmış lütfen başka bir kişi seçiniz.");
                        kAtananKisiId = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine("Hangi Line'a eklensin? TODO(1), InProgress(2), Done(3)  :");
                    string kLine = Console.ReadLine();
                    Buyukluk b = Buyukluk.XS;
                    if(kBuyukluk == "1"){
                        b = Buyukluk.XS;
                    }else if (kBuyukluk == "2"){
                        b = Buyukluk.S;        
                    }else if (kBuyukluk == "3"){
                        b = Buyukluk.M;
                    }else if (kBuyukluk == "4"){
                        b = Buyukluk.L;  
                    }else if (kBuyukluk == "5"){
                        b = Buyukluk.XL;
                    }else{
                        Console.WriteLine("Yanlış tuşlama yaptınız :(");
                    }
                    Line l = Line.TODO;
                    if(kLine == "1"){
                        l = Line.TODO;
                    }else if(kLine == "2"){
                        l = Line.InProgress;
                    }else if(kLine == "3"){
                        l = Line.Done;
                    }else{
                        Console.WriteLine("Yanlış tuşlama yaptınız :(");
                    }
                    Kart yeniKart = new Kart(kBaslik,kIcerik,b,l,kAtananKisiId);
                    //Board.Kartlar.Add(yeniKart); -> Bu Kart classı constructorında otomatik gerçekleşmektedir.
                }else if(bas == "3"){
                    Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.\n Lütfen kart başlığını yazınız: ");
                    string kartBasligi = Console.ReadLine();
                    bool varMi = Board.KartArama(kartBasligi);
                    if(varMi){  
                        Board.KartSil(kartBasligi);
                        Console.WriteLine("Kart başarıyla silindi");
                    }else{
                        Console.WriteLine(" Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                        Console.WriteLine("* İşlemi sonlandırmak için : (1)\n* Yeniden denemek için : (2)");
                        string t = Console.ReadLine();
                        if(t=="1"){
                            break;
                        }else{
                            continue;
                        }
                    }
                }else if(bas == "4"){
                    Console.WriteLine("Öncelikle değiştirmek istediğiniz kartı seçmeniz gerekiyor.");
                    Console.WriteLine("Lütfen kart başlığını yazınız: ");
                    string st = Console.ReadLine();
                    bool kartVarMi = Board.KartArama(st);
                    if(kartVarMi){
                        Console.WriteLine("Bulunan Kart Bilgileri: ");
                        Board.KartGoruntule(st);
                        Console.WriteLine();
                        Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz:  ");
                        Console.WriteLine("(1) TODO\n(2) IN PROGRESS\n(3) DONE");
                        string stLine = Console.ReadLine();
                        if(stLine == "1"){
                            Kart c = Board.KartiVer(st);
                            Board.Kartlar.Remove(Board.KartiVer(st));
                            c.Line = Line.TODO;
                            Board.Kartlar.Add(c);
                            board.BoardGoruntule();
                        }else if(stLine == "2"){
                            Kart c = Board.KartiVer(st);
                            Board.Kartlar.Remove(Board.KartiVer(st));
                            c.Line = Line.InProgress;
                            Board.Kartlar.Add(c);
                            board.BoardGoruntule();
                        }else if(stLine == "3"){
                            Kart c = Board.KartiVer(st);
                            Board.Kartlar.Remove(Board.KartiVer(st));
                            c.Line = Line.Done;
                            Board.Kartlar.Add(c);
                            board.BoardGoruntule();  
                        }else{
                            Console.WriteLine("Hatalı bir seçim yaptınız!");
                        }

                    }else{
                        Console.WriteLine("Girdiğiniz başlıkta bir kart bulunamadı!!!");
                    }
                }else{
                    Console.WriteLine("Hatalı tuşlama yaptınız. Lütfen tekrar deneyiniz. ");
                    
                }


            }
            

        }
    }
}
