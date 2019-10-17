using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace PFR
{
    enum couleurZ { bleuatre, grisatre }
    class Zombie : Monstre
    {

        private int degreDeComposition;
        private couleurZ teint;
        private bool invisibilite;

        public Zombie(string fct, int mat, string n, string p, TypeSexe sexe, int cagn, string affect, int degreDeCompo, couleurZ teint, bool invisibilite) : base(fct, mat, n, p, sexe, cagn, affect)
        {
            this.degreDeComposition = degreDeCompo;
            this.teint = teint;
            this.invisibilite = false;
        }

        public int DegreDeComposition
        {
            get { return this.degreDeComposition; }
            set { this.degreDeComposition = value; }
        }
        public couleurZ Teint
        {
            get { return this.teint; }
        }

        public bool Invisible
        {
            get { return this.invisibilite; }
            set { this.invisibilite = value; }
        }

        public void EvolutionDegreDeDecompo(int newdegre)
        {
            degreDeComposition = newdegre;
        }


        //Si la cagnotte des zombies ou des démons dépasse 500, ils obtiennent de façon provisoire
        //le pouvoir de disparaitre. 
        static public void Invisibilite(Zombie zomb)
        {
            if (zomb.cagnotte > 500)
            {
                Console.WriteLine("Le Zombie a désormais une cagnotte >500, il peut donc disparaitre. ");
                zomb.invisibilite = true;
            }
            else
            {
                zomb.invisibilite = false;
            }
        }

        public override string ToString()
        {
            string descr = base.ToString();
            descr += "Degré de composition : " + this.degreDeComposition + "Teint : " + this.teint;
            return descr;
        }
    }
}
