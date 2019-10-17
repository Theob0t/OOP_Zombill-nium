using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace PFR
{
    enum TypeBoutique { souvenir, barbeApapa, nourriture }
    class Boutique : Attraction
    {
        private TypeBoutique type;

        public Boutique(string besoinSpe, TimeSpan dureeMaint, List<Monstre> equipe, int id, bool maint, string natureMaint, int nbMinMonstre, string nom, bool ouvert, string typeDeBesoin, TypeBoutique type) : base(besoinSpe, dureeMaint, equipe, id, maint, natureMaint, nbMinMonstre, nom, ouvert, typeDeBesoin)
        {
            this.type = type;
        }

        public TypeBoutique Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public void EvolutionType(TypeBoutique newtype)
        {
            type = newtype;
        }


        public override string ToString()
        {
            string descri = base.ToString();
            descri += "Type : " + this.type;
            return descri;
        }
    }
}
