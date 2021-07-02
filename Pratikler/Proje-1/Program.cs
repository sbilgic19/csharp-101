using System;

namespace Proje_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Owner owner = new("Serkan","Berk","00000000000", new TelefonRehberi());

            Kisiler kisi1 = new Kisiler("Ayşe","Yılmaz","09090909091");
            Kisiler kisi2 = new Kisiler("Ali","Yılmaz","11111111111");
            Kisiler kisi3 = new Kisiler("Ahmet","Yılmaz","22222222222");
            Kisiler kisi4 = new Kisiler("Turan","Yılmaz","33333333333");
            Kisiler kisi5 = new Kisiler("Ceyda","Yılmaz","44444444444");

            // fullName methods returns List<string> first element of this list is name and second is surname
            owner.Rehberim.NumaraEkle(kisi1.fullName(),kisi1.PhoneNumber);
            owner.Rehberim.NumaraEkle(kisi2.fullName(),kisi2.PhoneNumber);
            owner.Rehberim.NumaraEkle(kisi3.fullName(),kisi3.PhoneNumber);
            owner.Rehberim.NumaraEkle(kisi4.fullName(),kisi4.PhoneNumber);
            owner.Rehberim.NumaraEkle(kisi5.fullName(),kisi5.PhoneNumber);



            bool menu = true;

            while(menu){
                Console.WriteLine();
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
                Console.WriteLine("*******************************************");
                Console.WriteLine("(1) Yeni Numara Kaydetmek\n(2) Varolan Numarayı Silmek\n(3) Varolan Numarayı Güncelleme\n(4) Rehberi Listelemek\n(5) Rehberde Arama Yapmak\nÇıkış yapmak için lütfen 0'a basınız.\n");
                string s = Console.ReadLine();

                if (s == "0"){
                    menu = false;
                }else if(s == "1"){
                    Console.Write("Lütfen isim giriniz        :");
                    string isim = Console.ReadLine();
                    Console.Write("Lütfen soyisim giriniz         :");
                    string soyisim = Console.ReadLine();
                    Console.Write("Lütfen telefon numarası giriniz       :");
                    string tel = Console.ReadLine();
                    Kisiler newKisi = new Kisiler(isim, soyisim, tel);
                    owner.Rehberim.NumaraEkle(newKisi.fullName(),newKisi.PhoneNumber);
                    Console.WriteLine("Yeni kişi {0} {1} başarıyla eklendi. ",isim,soyisim);
                }else if (s == "2"){
                    Console.Write("  Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
                    string str = Console.ReadLine();
                    bool islem = owner.Rehberim.NumaraVarMi(str);
                    if(islem){
                        Console.WriteLine(" {0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)",str);
                        string deger = Console.ReadLine();
                        if (deger == "y"){
                            owner.Rehberim.NumaraSilmeOnaylandi(str);
                            foreach(var val in Kisiler.KisiListesi.ToArray()){
                                foreach(var i in val){
                                    if(i == str){
                                        Kisiler.KisiListesi.Remove(val);
                                    }
                                }
                            }
                            Console.WriteLine("Silme başarıyla tamamlandı.");
                        }else{
                            Console.WriteLine("Silme işlemi iptal edildi.");
                        }
                    }else{
                        Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                        Console.WriteLine("* Silmeyi sonlandırmak için : (1)\n* Yeniden denemek için      : (2)");
                        string deger = Console.ReadLine();
                        if (deger == "1"){
                            break;
                        }else{
                            continue;
                        }

                    }
                }else if(s=="3"){
                    Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
                    string d = Console.ReadLine();
                    bool varMi = owner.Rehberim.NumaraVarMi(d);
                    if(varMi){
                        Console.WriteLine("Yeni numarayı giriniz.");
                        string num = Console.ReadLine();
                        owner.Rehberim.NumaraGuncelle(d,num);
                        Console.WriteLine("Numara başarıyla güncellendi");
                    }else{
                        Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                        Console.WriteLine("* Silmeyi sonlandırmak için : (1)\n* Yeniden denemek için      : (2)");
                        string g = Console.ReadLine();
                        if (g == "1"){
                            break;
                        }else{
                            continue;
                        }
                    }

                }else if(s=="4"){
                    Console.WriteLine("Telefon Rehberi");
                    Console.WriteLine("***********************************************");
                    foreach(var i in owner.Rehberim.Contacts.Keys){
                        Console.WriteLine("İsim: {0}\nSoyisim: {1}\nTelefon Numarası: {2}\n- ",i[0],i[1],owner.Rehberim.Contacts[i]);
                    }
                }else if(s=="5"){
                    Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
                    Console.WriteLine("**********************************************\n");
                    Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
                    Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
                    string arama = Console.ReadLine();
                    if(arama == "1"){
                        Console.WriteLine("İsim ya da soyisim giriniz");
                        string ad = Console.ReadLine();
                        bool no = owner.Rehberim.NumaraVarMi(ad);
                        if(no){
                            Console.WriteLine("Arama Sonuçlarınız: ");
                            Console.WriteLine("**********************************************");
                            foreach(var kisi in Kisiler.KisiListesi){
                                if (kisi.Contains(ad)){
                                    owner.Rehberim.AramaSonucuYazdir(kisi[0],kisi[1],kisi[2]);
                                }
                            }
                        }else{
                            Console.WriteLine("Numara bulunamadı. ");
                        }
                    }else{
                        Console.WriteLine("Telefon numarası giriniz");
                        string ad = Console.ReadLine();
                        bool no = owner.Rehberim.NumaraVarMiTelNo(ad);
                        if(no){
                            Console.WriteLine("Arama Sonuçlarınız: ");
                            Console.WriteLine("**********************************************");
                            foreach(var kisi in Kisiler.KisiListesi){
                                if (kisi[2] == ad){
                                    owner.Rehberim.AramaSonucuYazdir(kisi[0],kisi[1],kisi[2]);
                                }
                            }

                        }else{
                            Console.WriteLine("Numara bulunamadı. ");
                        }

                    }

                }else{
                    Console.WriteLine("Yanlış tuşlama yaptınız lütfen tekrar deneyiniz. \n");
                }

                               
            }
        }
    }
}
