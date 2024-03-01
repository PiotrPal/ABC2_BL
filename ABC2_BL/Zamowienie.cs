using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC2_BL
{
    public class Zamowienie
    {
        public Zamowienie() { }

        public Zamowienie(int zamowienieID)
        {
            ZamowienieID = zamowienieID;
        }
        public int ZamowienieID { get; private set; }
        public DateTimeOffset? DataZamowienia { get; set; }

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
        public bool Zwaliduj()
        {
            var poprawne = true;
            if (DataZamowienia == null)
            {
                poprawne = false;
            }

            return poprawne;
        }
    }
}
