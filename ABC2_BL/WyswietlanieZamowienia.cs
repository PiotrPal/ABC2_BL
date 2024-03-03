using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC2_BL
{
    public class WyswietlanieZamowienia
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public DateTimeOffset? DataZamowienia { get; set; }
        public List<WyswietlaniePozycjiZamowienia> WyswietlaniePozycjiZamowieniaLista { get; set; }
        public int ZamowienieID { get; set; }
        public Adres AdresDostawy { get; set; }

    }
}
