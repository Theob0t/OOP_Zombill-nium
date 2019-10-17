using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace PFR
{
    class LoupGarou : Monstre
    {
        private double indiceCruaute;

        public LoupGarou(string fct, int mat, string n, string p, TypeSexe sexe, int cagn, string affect, double idCruaute) : base(fct, mat, n, p, sexe, cagn, affect)
        {
            this.indiceCruaute = idCruaute;
        }

        public double IndiceCruaute
        {
            get { return this.indiceCruaute; }
        }

        public override string ToString()
        {
            string de = base.ToString();
            de = "Indice de cruauté : " + this.indiceCruaute;
            return de;
        }



    }
}
