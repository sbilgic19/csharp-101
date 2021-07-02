using System;

namespace Proje_2
{
    class Kisiler  
    {   
        private string name;
        private string surname;
        private int id;
        private static int counter = 1;
        public Kisiler(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
            this.id = counter;
            counter++;
        }
        public int Id { get => id; set => id = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Name { get => name; set => name = value; }

        public string fullName(){
            return name+" "+surname;
        }

       




    }




}