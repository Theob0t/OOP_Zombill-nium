using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace PFR
{
    enum TypeCategorie { assise, inversee, bobsleigh }
    class RollerCoaster : Attraction
    {
        private int ageMinimum;
        TypeCategorie categorie;
        float tailleMinimum;

        public RollerCoaster(string besoinSpe, TimeSpan dureeMaint, List<Monstre> equipe, int id, bool maint, string natureMaint, int nbMinMonstre, string nom, bool ouvert, string typeDeBesoin, int ageMin, TypeCategorie categorie, float tailleMin) : base(besoinSpe, dureeMaint, equipe, id, maint, natureMaint, nbMinMonstre, nom, ouvert, typeDeBesoin)
        {
            this.ageMinimum = ageMin;
            this.categorie = categorie;
            this.tailleMinimum = tailleMin;
        }

     

        public int AgeMinimum
        {
            get { return this.ageMinimum; }      
            
        }

        public TypeCategorie Categorie
        {
            get { return this.categorie; }
            set { this.categorie=value; }
        }
        

       public float TailleMinimum
        {
            get { return this.tailleMinimum; }
        }

        public void EvolutionCategorie(TypeCategorie newcategorie)
        {
            categorie = newcategorie;
        }

        public override string ToString()
        {
            string descr = base.ToString();
            descr = "Age minimum : " + this.ageMinimum + "Catégorie : " + this.categorie + "Taille minimum : " + this.tailleMinimum;
            return descr;
        }
        


    }
}
