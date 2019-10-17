using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace PFR
{
    class Demon : Monstre
    {
        private int force;
        private bool invisibilite;

        public Demon(string fct, int mat, string n, string p, TypeSexe sexe, int cagn, string affect, int force, bool invisibilite) : base(fct, mat, n, p, sexe, cagn, affect)
        {
            this.force = force;
            this.invisibilite = false;
        }

        public int Force
        {
            get { return this.force; }
            set { this.force = value; }
        }
        public bool Invisible
        {
            get { return this.invisibilite; }
            set { this.invisibilite = value; }
        }

        public void EvolutionForce(int newforce)
        {
            force = newforce;
        }

        public void Invisibilite()
        {
            if (cagnotte > 500)
            {
                Console.WriteLine("Le Démon a désormais une cagnotte >500, il peut donc disparaitre. ");
                invisibilite = true;
            }
            else
            {
                invisibilite = false;
            }
        }

        public override string ToString()
        {
            string d = base.ToString();
            d += "Force : " + this.force;
            return d;
        }
    }
}
