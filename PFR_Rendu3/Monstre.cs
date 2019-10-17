using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace PFR
{
    class Monstre : Personnel, IComparable<Monstre>
    {
        protected int cagnotte;
        private string affectation;

        public Monstre(string fct, int mat, string n, string p, TypeSexe sexe, int cagn, string affect) : base(fct, mat, n, p, sexe)
        {
            this.cagnotte = cagn;
            this.affectation = affect;
        }

        public int Cagnotte
        {
            get { return this.cagnotte; }
            set { this.cagnotte = value; }
        }

        public string Affectation
        {
            get { return this.affectation; }
            set { this.affectation = value; }
        }

        public int CompareTo(Monstre mons)
        {
            return this.cagnotte.CompareTo(mons.cagnotte); //Trie auto par rapport a cagnotte
        }
        

        public override string ToString()
        {
            string des = base.ToString();
            des += "Affectation : " + this.affectation + "Cagnotte : " + this.cagnotte;
            return des;
        }
    }
}
