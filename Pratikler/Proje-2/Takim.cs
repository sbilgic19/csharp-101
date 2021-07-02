using System;
using System.Collections;
using System.Collections.Generic;

namespace Proje_2
{
    class Takim  
    {

        private List<Kisiler> members;

        private int id;
        private static int counter = 1;
       

        public List<Kisiler> Members { get => members; set => members = value; }
    

        public Takim(List<Kisiler> members)
        {
            this.Members = members;
            this.id = counter;
            counter++;
            
        }
    }





}