using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace PFR
{
    class Spectacle : Attraction
    {
        private string horaire;
        private int nombrePlace;
        private string nomSalle;

        public Spectacle(string besoinSpe, TimeSpan dureeMaint, List<Monstre> equipe, int id, bool maint, string natureMaint, int nbMinMonstre, string nom, bool ouvert, string typeDeBesoin,string horaire, int nbPlace, string nomSalle) : base(besoinSpe, dureeMaint, equipe, id, maint, natureMaint, nbMinMonstre, nom, ouvert, typeDeBesoin)
        {
            this.nombrePlace = nbPlace;
            this.nomSalle = nomSalle;
        }

        public int NombrePlace
        {
            get { return this.nombrePlace; }
        }

        public string NomSalle
        {
            get { return this.nomSalle; }
        }

        public string Horaire
        {
            get { return this.horaire; }
            set { this.horaire = value; }
        }

        public void EvolutionHoraire(string newdate)
        {
            horaire = newdate;
        }

       public override string ToString()
        {
            string desc = base.ToString();
            desc += "Nombre de places : " + this.nombrePlace + "Nom de la salle : " + this.nomSalle;
            return desc;
        }
        
    }
}
