using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC2_BL
{
    public class ProduktRepository
    {
        public Produkt Pobierz(int produktID)
        {
            var produkt = new Produkt(produktID);

            Object obiekt = new Object();

            Console.WriteLine("obiekt: " + obiekt.ToString());
            Console.WriteLine("obiekt: " + produkt.ToString());

            //kod kotry pobiera zdefiniowany produkt

            //tymczasowy kod
            if (produktID == 2) 
            {
                produkt.NazwaProduktu = "Klocki";
                produkt.Opis = "Lego samochod wyscigowy";
                produkt.AktualnaCena = 250.99M;
            }

            return produkt;
        }
        public bool Zapisz(Produkt produkt)
        {
            var sukces = true;

            if(produkt.maZmiany && produkt.danePrawidlowe)
            {
                if (produkt.jestNowy)
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
