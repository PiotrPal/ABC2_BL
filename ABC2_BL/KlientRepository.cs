using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC2_BL
{
    public class KlientRepository
    {
        private AdresRepository adresRepository {  get; set; }

        public KlientRepository()
        {
            adresRepository = new AdresRepository();
        }

        public bool Zapisz(Klient klient)
        {
            // kod kotry zapisuje zdefiniowanego klienta
            return true;
        }
        public Klient Pobierz(int klientID)
        {
            Klient klient = new Klient(klientID);
            klient.ListaAdresow = adresRepository.PobierzPoKlientID(klientID).ToList();

            // kod ktory pobiera okreslonego klienta

            //tymczasowe wartosci

            if(klientID == 1)
            {
                klient.Email = "tomekk@gmail.com";
                klient.Imie = "Tomekk";
                klient.Nazwisko = "Nowicki";
            }

            return klient;
        }
        public List<Klient> Pobierz()
        {
            //kod ktory pobiera wszystkich klientow
            return new List<Klient>();
        }
    }
}
