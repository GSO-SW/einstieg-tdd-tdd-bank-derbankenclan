using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Tagesgeld
    {
        private Konto konto = null!; //Ausrufezeichen verwirft/ignoriert Warnung (grüngewellte Unterstreichung, beim Wert NULL) 
        //private Konto konto ist ein Platzhalter für die verwendete Variable konto, die auf die Klasse bzw. ein Objekt der Klasse Konto verweist. (innerhalb der Klasse Konto würde bedeuten, dass es fest zu der Klasse gehört z.B. private int KontoNr)
        //"private Konto konto" ist ein Platzhalter/ein Verweis auf ein Objekt vom Typ konto, welches bereits existiert.
        //Im Konstruktor der Klasse Tagesgeld wird diesem Platzhalter ein entsprechendes Konto zugewiesen

        private int verechnungsKontoNr;
        //{
        //    get { return konto.KontoNr; } <- vereinfachte Versiono Maximo
        //}
        public int VerrechnungsKontoNr
        {
            get { return verechnungsKontoNr; }

        }

        private double guthaben;
        public double Guthaben
        {
            get { return guthaben; }
            set { guthaben = value; }
        }

        private double zinssatz;
        public double Zinssatz
        {
            get { return zinssatz; }
            set { zinssatz = value; }
        }

        private double einzahlungsbetrag;

        public double Einzahlungsbetrag
        {
            get { return einzahlungsbetrag; }
            set { einzahlungsbetrag = value; }
        }


        public Tagesgeld(Konto konto)
        {
            this.verechnungsKontoNr = konto.KontoNr;
            this.guthaben = 0;
            this.zinssatz = 0;
            this.konto = konto;
        }

        public void Einzahlen(double einzahlungsbetrag)
        {
            konto.Auszahlen(einzahlungsbetrag);
            guthaben += einzahlungsbetrag;
        }

        public void Auszahlen(double auszahlungsbetrag)
        {
            if(guthaben - auszahlungsbetrag < 0)
            {
                throw new ArgumentOutOfRangeException("Digga, deine Mutter ist so fett, dass du das nicht zahlen kannst. Gib auf und schläfere sie ein. Die Brücke sagt Hallo!");
            }

            konto.Einzahlen(auszahlungsbetrag);
            guthaben -= auszahlungsbetrag;

        }
    }
}
