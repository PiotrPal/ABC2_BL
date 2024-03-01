using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC2_BL
{
    public class PozycjaZamowienia
    {
        public PozycjaZamowienia()
        {
            
        }

        public PozycjaZamowienia(int pozaycjaZamowieniaID)
        {
            PozycjaZamowieniaID = pozaycjaZamowieniaID;
        }
        public int PozycjaZamowieniaID {get; private set;}
        public int Ilosc { get; set; }
        public int ProduktId { get; set; }
        public decimal? Cenazakupu { get; set; }

        public PozycjaZamowienia Pobierz(int pozaycjaZamowieniaID)
        {
            //kod ktory pobiera zdefiniowany elemnent zamowienia
            return new PozycjaZamowienia();
        }
        public bool Zapisz()
        {
            //kod ktory zapisuje zdefiniowany elemnent zamowienia
            return true;
        }
        public bool Zwaliduj()
        {
            var poprawne = true;
           
            if(Ilosc <= 0) poprawne = false;
            if (ProduktId <= 0) poprawne = false;
            if (Cenazakupu == null) poprawne = false;

            return poprawne;
        }

    }
}
