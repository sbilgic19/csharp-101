using System;

namespace interface_sample
{

    public class Civic : IOtomobil
    {
        public Marka HangiMarka()
        {
            return Marka.Honda;
        }

        public int KacTekerlek()
        {
            return 4;
        }

        public Renk StandartRengi()
        {
            return Renk.Gri;
        }
    }



}