using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC2_BL
{
    public class Produkt
    {
        public Produkt() { }

        public Produkt(int produktID) 
        {
            ProduktID = produktID;
        }

        public int ProduktID { get; private set; }
        public decimal?  AktualnaCena { get; set; }
        public string Opis {  get; set; }  
        public string NazwaProduktu { get; set;}

        public Produkt Pobierz(int produktID) 
        { 
            //kod kotry pobiera zdefiniowany produkt
            return new Produkt(); 
        }
        public bool Zapisz()
        {
            //kod ktory zapisuje zdefiniowany produkt
            return true;
        }
        public bool Zwaliduj()
        {
            var poprawne = true;
            if (string.IsNullOrWhiteSpace(NazwaProduktu))
            {
                poprawne = false;
            }

            return poprawne;
        }
    }
}
