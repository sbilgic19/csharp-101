using System;
using System.Collections;
using System.Collections.Generic;

namespace Proje_1
{
    class TelefonRehberi
    {

        public Dictionary<List<string>, string> contacts;

        public TelefonRehberi()
        {
            contacts = new();
        }

        public Dictionary<List<string>, string> Contacts { get => contacts; set => contacts=value;}
        

        public void NumaraEkle(List<string> fullname, string phoneNumber){
            try{
                Contacts.Add(fullname, phoneNumber);
                Console.WriteLine("Yeni kişi eklendi. ");
            }catch(Exception ex){
                Console.WriteLine("Beklenmeyen bir hata oluştu. Hata Detayı: {0} ",ex);
            }
           
        }
        // false numara var, true numara yok
        public bool NumaraVarMi(string s){
            foreach(var val in Contacts.Keys){
                foreach(var i in val){
                    if (s==i){
                        return true;
                    }
                }
            }
            return false;
        }
        public void NumaraSilmeOnaylandi(string s){
            foreach(var val in Contacts.Keys){
                foreach(var i in val){
                    if (s==i){
                        Contacts.Remove(val);
                        return;
                    }
                }
            }
        }
        public void NumaraGuncelle(string s, string newNumara){
            foreach(var val in Contacts.Keys){
                foreach(var i in val){
                    if (s==i){
                        Contacts[val] = newNumara;
                    }
                }
            }
        }
        public bool NumaraVarMiTelNo(string telNo){
            return Contacts.ContainsValue(telNo);
        }

       

        public void AramaSonucuYazdir(string s1, string s2, string s3){
            Console.WriteLine("İsim: {0}\nSoyisim: {1}\nTelefon Numarası: {2}\n- ",s1,s2,s3);   
        }
    }



}