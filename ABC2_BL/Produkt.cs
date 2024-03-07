using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC2_BL
{
    public class Produkt : KlasaBazowa
    {
        public Produkt() { }

        public Produkt(int produktID) 
        {
            ProduktID = produktID;
        }

        public int ProduktID { get; private set; }
        public decimal?  AktualnaCena { get; set; }
        public string Opis {  get; set; }
        private string _NazwaProduktu;

        public string NazwaProduktu
        {
            get {
                return ObslugaString.wstawSpacje(_NazwaProduktu); 
            }
            set { _NazwaProduktu = value; }
        }

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
        public override bool Zwaliduj()
        {
            var poprawne = true;
            if (string.IsNullOrWhiteSpace(NazwaProduktu))
            {
                poprawne = false;
            }

            return poprawne;
        }

        public override string ToString()
        {
            return NazwaProduktu;
        }
    }
}
