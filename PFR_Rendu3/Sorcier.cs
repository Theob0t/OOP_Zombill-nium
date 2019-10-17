using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace PFR
{
    enum Grade { novice, mega, giga, strata }
    class Sorcier : Personnel

    {
        private Grade tatouage;
        private List<string> pouvoir;

        public Sorcier(string fct, int mat, string n, string p, TypeSexe sexe, Grade tatouage, List<string> pouvoir) : base(fct, mat, n, p, sexe)
        {
            this.tatouage = tatouage;
            this.pouvoir = pouvoir;
        }

        public Grade Tatouage
        {
            get { return this.tatouage; }
            set { this.tatouage=value; }
        }

        public List<string> Pouvoir
        {
            get { return this.pouvoir; }
            set { this.pouvoir = value; }
        }

        public void EvolutionTatouage(Grade newtatoo)
        {
            tatouage = newtatoo;
        }

        public void EvolutionPouvoir(List<string> newpower)
        {
            pouvoir = newpower;
        }
        public override string ToString()
        {
            string descr = base.ToString();
            descr += "Tatouage: " + this.tatouage + "Pouvoir : " + this.pouvoir;
            return descr;
        }
    }
}
