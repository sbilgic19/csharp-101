using System;
using System.Collections;
using System.Collections.Generic;

namespace Proje_1
{
    class Owner : Kisiler
    {
        private TelefonRehberi rehberim;

        public Owner(string name, string surname, string phoneNumber, TelefonRehberi rehberim)
        {
            this.Name = name;
            this.Surname = surname;
            this.PhoneNumber = phoneNumber;
            this.Rehberim = rehberim;
            Console.WriteLine("Telefon rehberi oluşturuldu. Bu rehber {0} {1} adlı {2} telefon numaralı kişiye aittir. ", name, surname, phoneNumber);
            
        }

        public TelefonRehberi Rehberim { get => rehberim; set => rehberim = value; }
    }





}