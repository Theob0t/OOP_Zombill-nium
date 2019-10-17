using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace PFR
{
    class Vampire : Monstre
    {
        private double indiceLuminosite;

        public Vampire(string fct, int mat, string n, string p, TypeSexe sexe, int cagn, string affect, double idLum) : base(fct, mat, n, p, sexe, cagn, affect)
        {
            this.indiceLuminosite = idLum;
        }

        public double IndiceLum
        {
            get { return this.indiceLuminosite; }
            set { this.indiceLuminosite = value; }
        }

        public void EvolutionIndice(double newindice)
        {
            indiceLuminosite = newindice;
        }

        public override string ToString()
        {
            string de = base.ToString();
            de += "Indice de luminosité : " + this.indiceLuminosite;
            return de;
        }
    }
}
