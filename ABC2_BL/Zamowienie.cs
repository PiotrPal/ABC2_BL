using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC2_BL
{
    public class Zamowienie : KlasaBazowa, ILogowanie
    {
        public Zamowienie() { }

        public Zamowienie(int zamowienieID)
        {
            ZamowienieID = zamowienieID;
        }
        public int ZamowienieID { get; private set; }
        public DateTimeOffset? DataZamowienia { get; set; }
        public List<PozycjaZamowienia> pozycjeZamowienia { get; set; }
        public int KlientID { get; set; }
        public int AdresDostawyID { get; set; }
        public Zamowienie Pobierz(int zamowienieID)
        {
            //kod kotry pobiera zdefiniowane zamowienie
            return new Zamowienie();
        }
        public bool Zapisz()
        {
            //kod ktory zapisuje zdefiniowane zamownienie
            return true;
        }
        public override bool Zwaliduj()
        {
            var poprawne = true;
            if (DataZamowienia == null)
            {
                poprawne = false;
            }

            return poprawne;
        }

        public override string ToString()
        {
            return DataZamowienia + " ID[ " + ZamowienieID + " ] ";
        }

        public string Log()
        {
            var logText = "[" + ZamowienieID + "] Data:" + DataZamowienia + " Pozycje: " + pozycjeZamowienia + " Status: " + stanObiektu.ToString();
            return logText;
        }
    }
}
