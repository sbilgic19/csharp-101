namespace interface_sample
{
    class NewCivic : Otomobil
    {
        public override Marka HangiMarka()
        {
            return Marka.Toyota;
        }

        public override Renk StandartRengi()
        {
            return Renk.Gri;
        }

    }
}