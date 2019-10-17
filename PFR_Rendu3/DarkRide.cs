using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace PFR
{
    class DarkRide : Attraction
    {
        private TimeSpan duree;
        private bool vehicule;

        public DarkRide(string besoinSpe, TimeSpan dureeMaint, List<Monstre> equipe, int id, bool maint, string natureMaint, int nbMinMonstre, string nom, bool ouvert, string typeDeBesoin, TimeSpan duree, bool vehicule) : base(besoinSpe, dureeMaint, equipe, id, maint, natureMaint, nbMinMonstre, nom, ouvert, typeDeBesoin)
        {
            this.duree = duree;
            this.vehicule = vehicule;
        }

        public TimeSpan Duree
        {
            get { return this.duree; }
            set { this.duree = value; }
        }


        public bool Vehicule
        {
            get { return this.vehicule; }
        }

        public void EvolutionDuree(TimeSpan newduree)
        {
            duree = newduree;
        }

        public void EvolutionVehicule(bool newvehicule)
        {
            vehicule = newvehicule;
        }


        public override string ToString()
          {
              string descri = base.ToString();
              descri = "Durée : " + this.duree + "Vehicule : " + this.vehicule;
              return descri;
          }


    }
}
