using System;

namespace Bank
{
    public class Konto
    {
        private double guthaben;
        private int kontoNr;
        private static int anzahlKonten = 0;

        public int KontoNr
        {
            get { return kontoNr; }
        }



        public double Guthaben
        {
            get
            {
                return guthaben;
            }
        }

        public Konto(double guthaben)
        {
            if (guthaben < 0)
            {
                throw new ArgumentOutOfRangeException("Eröffnungsbetrag darf nicht negativ sein.");
            }

            this.guthaben = guthaben;
            this.kontoNr = anzahlKonten++; //wird hier zuerst um einen Wert ('++') erhöht und dann werden die Brötchen mitgenommen. Hehehe. (deklariert). / 'this.' ist hier nicht nötig, weil es kein zu übergebender Parameter ist, von dem wir unterscheiden müssen.
            
        }

        public void Einzahlen(double betrag)
        {
            guthaben += betrag;
        }

        public void Auszahlen(double betrag)
        {
            if (guthaben >= betrag)
            {
                guthaben -= betrag;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Guthaben nicht ausreichend");
            }
        }
    }
}
