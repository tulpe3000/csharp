using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZinsZins
{
    public class Zins
    {

        public double BerechneZins(int kapital, int laufzeit, int zinsen)
        {
            double summe = kapital;
            for (int i = 0; i < laufzeit; i++)
            {
                summe += (summe * zinsen)/100;
            }
            summe = Math.Round(summe,2);
            return summe;
        }
    }
}
