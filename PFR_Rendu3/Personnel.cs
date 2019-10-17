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
    public enum TypeSexe { male, femelle, autre}
    class Personnel: IComparable<Personnel>, INotifyPropertyChanged
    {
        private string fonction;
        private int matricule;
        private string nom;
        private string prenom;
        private TypeSexe sexe;

        //Interface, Cela sert à pouvoir changer une propriété
        public event PropertyChangedEventHandler PropertyChanged;

        public Personnel(string fct, int mat, string n, string p, TypeSexe sexe)
        {
            this.fonction = fct;
            this.matricule = mat;
            this.nom = n;
            this.prenom = p;
            this.sexe = sexe;
        }

        public string Fonction
        {
            get { return this.fonction; }
            set
            {
                if (value != this.fonction)
                {
                    fonction = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Fonction")); //pour pouvoir modif à partir de l'interface
                    }
                }
            }

        }

        public int Matricule
        {
            get { return this.matricule; }
            set
            {
                if (value != this.matricule)
                {
                    matricule = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Matricule"));
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
                        PropertyChanged(this, new PropertyChangedEventArgs("Nom"));
                    }
                }
            }

        }

        public string Prenom
        {
            get { return this.prenom; }
            set
            {
                if (value != prenom)
                {
                    prenom = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Prenom"));
                    }
                }
            }
        }

        public TypeSexe Sexe
        {
            get { return this.sexe; }
            set
            {
                if (value != sexe)
                {
                    sexe = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Sexe"));
                    }
                }
            }
        }

        public void EvolutionPersonnel(string newfonction)
        {
            fonction=newfonction;

        }

        public int CompareTo(Personnel personnel)
        {
            return this.nom.CompareTo(personnel.nom); //Trie auto par rapport au nom
        }



        public override string ToString()
        {
            string description = "";
            description = "Fonction : " + this.fonction + " Matricule : " + this.matricule + " Nom : " + this.nom + " Prenom : " + this.prenom + " Sexe : " + this.sexe;
            return description;
        }


    }
}

