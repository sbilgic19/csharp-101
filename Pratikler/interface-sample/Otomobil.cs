namespace interface_sample
{
    abstract class Otomobil
    {

        public int KacTekerlek(){
            return 4;
        }

        public virtual Renk StandartRengi(){
            return Renk.Beyaz;
        }

        public abstract Marka HangiMarka();


    }



}