using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.ComponentModel;

namespace PFR
{
    class Attraction: INotifyPropertyChanged
    {
        private string besoinSpecifique;
        private TimeSpan dureeMaintenance;
        private List<Monstre> equipe;
        private int identifiant;
        private bool maintenance;
        private string natureMaintenance;
        private int nbMinMonstre;
        private string nom;
        private bool ouvert;
        private string typeDeBesoin;

        public Attraction(string besoinSpe, TimeSpan dureeMaint, List<Monstre> equipe, int id, bool maint, string natureMaint, int nbMinMonstre, string nom, bool ouvert, string typeDeBesoin)
        {
            this.besoinSpecifique = besoinSpe;
            this.dureeMaintenance = dureeMaint;
            this.equipe = equipe;
            this.identifiant = id;
            this.maintenance = maint;
            this.natureMaintenance = natureMaint;
            this.nbMinMonstre = nbMinMonstre;
            this.nom = nom;
            this.ouvert = ouvert;
            this.typeDeBesoin = typeDeBesoin;
        }

        public string BesoinSpecifique
        {
            get { return this.besoinSpecifique; }
            set
            {
                if (value != this.besoinSpecifique)
                {
                    besoinSpecifique = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("BesoinSpecifique")); 
                    }
                }
            }
        }

        public TimeSpan DureeMaintenance
        {
            get { return this.dureeMaintenance; }
            set
            {
                if (value != this.dureeMaintenance)
                {
                    dureeMaintenance = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("DureedeMaintenance")); 
                    }
                }
            }
        }
        public List<Monstre> Equipe
        {
            get { return this.equipe; }
            set
            {
                if (value != this.equipe)
                {
                    equipe = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Equipe")); 
                    }
                }
            }
        }
        public int Identifiant
        {
            get { return this.identifiant; }
            set
            {
                if (value != this.identifiant)
                {
                    identifiant = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Identifiant"));
                    }
                }
            }
        }
        public bool Maintenance
        {
            get { return this.maintenance; }
            set
            {
                if (value != this.maintenance)
                {
                    maintenance = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Maintenance")); 
                    }
                }
            }
        }
        public string NatureMaintenance
        {
            get { return this.natureMaintenance; }
            set
            {
                if (value != this.natureMaintenance)
                {
                    natureMaintenance = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("NatureMaintenance"));
                    }
                }
            }
        }
        public int NbMinMonstre
        {
            get { return this.nbMinMonstre; }
            set
            {
                if (value != this.nbMinMonstre)
                {
                    nbMinMonstre = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("NbMinMonstre")); //pour pouvoir modif à partir de l'interface
                    }
                }
            }
        }
        public string Nom
        {
            get { return this.nom; }
            set
            {
                if (value != this.nom)
                {
                    nom = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Nom")); //pour pouvoir modif à partir de l'interface
                    }
                }
            }
        }
        public bool Ouvert
        {
            get { return this.ouvert; }
            set
            {
                if (value != this.ouvert)
                {
                    ouvert = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Ouvert")); //pour pouvoir modif à partir de l'interface
                    }
                }
            }
        }
        public string TypeDeBesoin
        {
            get { return this.typeDeBesoin; }
            set
            {
                if (value != this.typeDeBesoin)
                {
                    typeDeBesoin = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("TypedeBesoin")); //pour pouvoir modif à partir de l'interface
                    }
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void EvolutionBesoinSpe(string newbesoin)
        {
            besoinSpecifique = newbesoin;
        }

        public void EvolutionDureeMaint(TimeSpan newdureemaint)
        {
            dureeMaintenance = newdureemaint;
        }

        public void EvolutionEquipe(List<Monstre> newequipe)
        {
            equipe = newequipe;
        }

        public void EvolutionMaintenance(bool newmaint)
        {
            maintenance = newmaint;
        }

        public void EvolutionNatureMaintenance(string newnaturemaint)
        {
            natureMaintenance = newnaturemaint;
        }

        public void EvolutionNbMinMonstre(int newnbmin)
        {
            nbMinMonstre = newnbmin;
        }

        public void EvolutionOuverture(bool newouvert)
        {
            ouvert = newouvert;
        }

        public void EvolutionTypeBesoin(string newtype)
        {
            typeDeBesoin = newtype;
        }

        public override string ToString()
        {
           string d = "";
            d = " Besoin Spécifique : " + this.besoinSpecifique + " Durée de la maintenance : " + this.dureeMaintenance + " Equipe : " + this.equipe + " Identifiant : " + this.identifiant + " Maintenance : " + this.maintenance + " Nature de la maintenance : " + this.natureMaintenance + " Nombre minimum de monstre : " + this.nbMinMonstre + " Nom : " + this.nom + " Ouvert : " + this.ouvert + " Type de besoin : " + this.typeDeBesoin;
            return d;
        }

    }
}
