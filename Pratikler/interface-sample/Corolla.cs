using System;

namespace interface_sample
{

    public class Corolla : IOtomobil
    {
        public Marka HangiMarka()
        {
            return Marka.Toyota;
        }

        public int KacTekerlek()
        {
            return 4;
        }

        public Renk StandartRengi()
        {
            return Renk.Beyaz;
        }
    }



}