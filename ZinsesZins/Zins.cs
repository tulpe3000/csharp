using System;

namespace ZinsesZins
{
    public class Zins
    {
        private double Kapital;
        private double Laufzeit;
        private double Zinsen;

        public Zins(int kapital,int laufzeit,int zinsen)
        {
            this.Kapital = kapital;
            this.Laufzeit = laufzeit;
            this.Zinsen = zinsen;
        }

        public double BerechneZins()
        {
            double summe = Kapital;
            for (int i = 0; i < Laufzeit; i++)
            {
                summe += summe * (1 + Zinsen / 100); 
            }
            return summe;
        }
    }
}
