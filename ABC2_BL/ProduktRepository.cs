﻿using System;
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

            //kod kotry pobiera zdefiniowany produkt

            //tymczasowy kod
            if(produktID == 2) 
            {
                produkt.NazwaProduktu = "Klocki";
                produkt.Opis = "Lego samochod wyscigowy";
                produkt.AktualnaCena = 250.99M;
            }

            return produkt;
        }
        public bool Zapisz()
        {
            //kod ktory zapisuje zdefiniowany produkt
            return true;
        }
    }
}