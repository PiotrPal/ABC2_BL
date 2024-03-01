using System;

namespace ABC2_BL
{
    public class ZamowienieRepository
    {
        public Zamowienie Pobierz(int zamowienieID)
        {
            var zamowienie = new Zamowienie(zamowienieID);
            //kod kotry pobiera zdefiniowane zamowienie

            //kod tymczaswoy
            if(zamowienieID == 3)
            {
                zamowienie.DataZamowienia = new DateTimeOffset(2024, 5, 3, 14, 00, 00, new TimeSpan(7, 0, 0));
            }

            return zamowienie;
        }
        public bool Zapisz()
        {
            //kod ktory zapisuje zdefiniowane zamownienie
            return true;
        }
    }
}
