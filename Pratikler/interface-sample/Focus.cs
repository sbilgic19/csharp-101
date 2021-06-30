using System;

namespace interface_sample
{

    public class Focus : IOtomobil
    {
        public Marka HangiMarka()
        {
            return Marka.Ford;
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