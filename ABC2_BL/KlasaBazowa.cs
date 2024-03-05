namespace ABC2_BL
{
    public abstract class KlasaBazowa
    {
        public bool jestNowy { get; set; }
        public bool maZmiany { get; set; }
        public StanObiektuOpcje stanObiektu { get; set; }
        public bool danePrawidlowe 
        { 
            get
            {
                return Zwaliduj();
            }
        }
        public abstract bool Zwaliduj();
        
    }

    public enum StanObiektuOpcje
    {
        Aktywne,
        Usuniete
    }
}
