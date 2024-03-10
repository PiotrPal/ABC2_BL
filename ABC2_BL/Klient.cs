using Common;
using System.Collections.Generic;

namespace ABC2_BL
{
    public class Klient : KlasaBazowa, ILogowanie
    {
        public Klient() : this(0)
        {

        }

        public Klient(int klientID)
        {
            KlientID = klientID;
            ListaAdresow = new List<Adres>();
        }

        public List<Adres> ListaAdresow { get; set; }
        public static int Licznik { get; set; }

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
                nazwisko = value;
            }
        }
        public string Imie { get; set; }

        public string Email { get; set; }

        public int KlientID { get; private set; }
        public int KlientTyp { get; set; }
        public string NazwiskoImie
        {
            get
            {
                string NazwiskoImie = Nazwisko;
                if (!string.IsNullOrWhiteSpace(Imie))
                {
                    if (!string.IsNullOrWhiteSpace(Nazwisko))
                    {
                        NazwiskoImie += ", ";
                    }
                    NazwiskoImie += Imie;
                }
                return NazwiskoImie;
            }
        }

        public override bool Zwaliduj()
        {
            var czy_poprawne = true;

            if (string.IsNullOrWhiteSpace(Nazwisko)) {
                czy_poprawne = false;
            }
            if (string.IsNullOrWhiteSpace(Email)) {
                czy_poprawne = false;
            }
            return czy_poprawne;
        }

        public bool Zapisz()
        {
            // kod kotry zapisuje zdefiniowanego klienta
            return true;
        }
        public Klient Pobierz(int KlientID)
        {
            // kod ktory pobiera okreslonego klienta
            return new Klient();
        }
        public List<Klient> Pobierz()
        {
            //kod ktory pobiera wszystkich klientow
            return new List<Klient>();
        }

        public override string ToString()
        {
            return NazwiskoImie;
        }

        public string Log()
        {
            var logText = "[" + KlientID + "] " + NazwiskoImie + " Email: " + Email + " Status: " + stanObiektu.ToString();
            return logText;
        }
    }
}
