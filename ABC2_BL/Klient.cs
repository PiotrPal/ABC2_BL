namespace ABC2_BL
{
    public class Klient
    {
        private string nazwisko;

        public string Nazwisko
        {
            get 
            { 
                //dodatkowy kod
                return nazwisko; 
            }
            set 
            {
                //dodakowy kod
                nazwisko = value;
            }
        }
        public string Imie { get; set; }

        public string Email { get; set; }

        public int KlientID { get; private set; }
        public string NazwiskoImie 
        {
           get
            {
                return Nazwisko + "," + Imie;
            }
        }
    }
}
