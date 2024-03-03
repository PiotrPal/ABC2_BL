using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC2_BL
{
    public class AdresRepository
    {
        public Adres Pobierz(int AdresID)
        {
            Adres adres = new Adres(AdresID);
            if(AdresID == 1 ) 
            {
                adres.AdresTyp = 1;
                adres.Ulica = "Diamentowa";
                adres.Miasto = "Lublin";
                adres.Kraj = "Polska";
                adres.KodPocztowy = "20-128";
            }
            return adres;
        }
        public IEnumerable<Adres> PobierzPoKlientID(int klientID) //pobieramy wszystkie adresy 
        {
            //kod ktory pobiera zdefiniowane adresy
            //tymczosowo
            var adresList = new List<Adres>();

            Adres adres = new Adres(1)
            {
                AdresTyp= 1,
                Ulica = "Poziomkowa",
                Miasto = "Katowice",
                KodPocztowy = "40-465",
                Kraj = "Polska"
            };
            adresList.Add(adres);

            adres = new Adres(2)
            {
                AdresTyp = 2,
                Ulica = "3maja",
                Miasto = "Siedlce",
                KodPocztowy = "80-110",
                Kraj = "Polska"
            };
            adresList.Add(adres);

            return adresList;
        }
        public bool Zapisz(Adres adres)
        {
            return true;
        }
    }
}
