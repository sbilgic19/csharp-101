using System;
using System.Collections;
using System.Collections.Generic;

namespace Proje_1
{
    class Kisiler
    {
        private string name;
        private string surname;
        private string phoneNumber;
        private List<string> kisiBilgileri;
        private static List<List<string>> kisiListesi = new();

        public Kisiler()
        {
        }

        public Kisiler(string name, string surname, string phoneNumber)
        {
            Name = name;
            Surname = surname;
            PhoneNumber = phoneNumber;
            kisiBilgileri = new();
            kisiBilgileri.Add(name);
            kisiBilgileri.Add(surname);
            kisiBilgileri.Add(phoneNumber);
            kisiListesi.Add(kisiBilgileri);
        }
        

        public string Name { get => name; set=> name = value;}
        public string Surname { get => surname; set=> surname = value;}
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public List<string> KisiBilgileri { get => KisiBilgileri; set => KisiBilgileri = value; }
        public static List<List<string>> KisiListesi { get => kisiListesi; set => kisiListesi = value; }

        public List<string> fullName(){
            List<string> fullNameList = new List<string>();
            fullNameList.Add(this.name);
            fullNameList.Add(this.surname);
            return fullNameList;
        }
    }




}