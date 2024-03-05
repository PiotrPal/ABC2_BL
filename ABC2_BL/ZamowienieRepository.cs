using System;
using System.Collections.Generic;

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
        public WyswietlanieZamowienia PobierzZamowienieDoWyswietlenia(int zamowienieID)
        {
            WyswietlanieZamowienia wyswietlanieZamowienia = new WyswietlanieZamowienia();

            //kod pobiera zdefiniowane pola zamowienia
            //kod temp
            if(zamowienieID == 10)
            {
                wyswietlanieZamowienia.Imie = "Marcin";
                wyswietlanieZamowienia.Nazwisko = "Nowak";
                wyswietlanieZamowienia.DataZamowienia=  new DateTimeOffset(2024,4,14,10,00,00,new TimeSpan(7, 0, 0));
                wyswietlanieZamowienia.AdresDostawy = new Adres()
                {
                    AdresTyp = 1,
                    Ulica = "Kosmiczna",
                    Miasto = "Warszawa",
                    KodPocztowy = "20-123",
                    Kraj = "Polska"
                };
            }
            wyswietlanieZamowienia.WyswietlaniePozycjiZamowieniaLista = new List<WyswietlaniePozycjiZamowienia>();
            //kod pobiera elemnty zamowieia
            //temp data
            if(zamowienieID == 10)
            {
                var wyswietlapniePozycjiZamowienia = new WyswietlaniePozycjiZamowienia()
                {
                    NazwaProduktu = "Krzeslo",
                    IloscZamowienia = 5,
                    CenaZakupu = 69.99M
                };
                wyswietlanieZamowienia.WyswietlaniePozycjiZamowieniaLista.Add(wyswietlapniePozycjiZamowienia);

                wyswietlapniePozycjiZamowienia = new WyswietlaniePozycjiZamowienia()
                {
                    NazwaProduktu = "Kanapa",
                    IloscZamowienia = 1,
                    CenaZakupu = 1300.99M
                };
                wyswietlanieZamowienia.WyswietlaniePozycjiZamowieniaLista.Add(wyswietlapniePozycjiZamowienia);
            }

            return wyswietlanieZamowienia;
        }
        public bool Zapisz(Zamowienie zamowienie)
        {
            var sukces = true;

            if (zamowienie.maZmiany && zamowienie.danePrawidlowe)
            {
                if (zamowienie.jestNowy)
                {
                    //wywolanie procedury insert
                }
                else
                {
                    //data update
                }
            }


            return sukces;
        }
    
    }
}
