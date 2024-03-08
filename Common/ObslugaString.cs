namespace Common
{
    public static class ObslugaString
    {
        public static string wstawSpacje(this string zrodlo)
        {
            var wynik = string.Empty;

            if(!string.IsNullOrWhiteSpace(zrodlo))
            {
                foreach(var litera in zrodlo)
                {
                    if (char.IsUpper(litera))
                    {
                        wynik = wynik.Trim();
                        wynik += " "; 
                    }
                    wynik += litera;
                }
                wynik = wynik.Trim(); //usuwanie spacji na koncu i na poczatku
            }

            return wynik;
        }
    }
}
