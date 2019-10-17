using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace PFR
{
    class Administration
    {
        private List<Attraction> attractions;
        private List<Personnel> toutLePersonnel;
        private List<Monstre> maListeMonstre;

        public Administration(List<Attraction> attractions, List<Personnel> toutLePersonnel,List<Monstre> maListeMonstre)
        {
            this.attractions = attractions;
            this.toutLePersonnel = toutLePersonnel;
            this.maListeMonstre = maListeMonstre;
        }

        public List<Attraction> Attractions
        {
            get { return this.attractions; }
            set { this.attractions=value;}
        }

        public List<Personnel> ToutLePersonnel
        {
            get { return this.toutLePersonnel; }
            set { this.toutLePersonnel = value; }
        }

        public List<Monstre> MaListeMonstre
        {
            get { return this.maListeMonstre; }
            set { this.maListeMonstre=value; }
        }


        

        static void AffichageListe(List<Personnel> liste)
        {
            for (int i = 0; i < liste.Count; i++)
            {
                Console.WriteLine(liste[i]);
            }
        }


        public Personnel AjoutPersonnel(string fct, int mat, string n, string p, TypeSexe sexe)
        {
            Console.WriteLine("Vous allez ajouter un nouveau membre du Personnel :");
            Personnel nouv = new Personnel(fct, mat, n, p, sexe);
            Console.WriteLine("Le nouveau membre est un " + fct + " son matricule est " + mat + ". Il s'appelle " + n + " " + p + " et est de sexe " + sexe);
            toutLePersonnel.Add(nouv);
            return nouv;
        }

        public Monstre AjoutMonstre(string fct, int mat, string n, string p, TypeSexe sexe, int cagn, string affect)
        {
            Console.WriteLine("Vous allez ajouter un nouveau membre du Personnel :");
            Monstre nouv = new Monstre(fct, mat, n, p, sexe, cagn, affect);
            
            maListeMonstre.Add(nouv);
            return nouv;
        }

        public Attraction AjoutAttraction(string besoinSpe, TimeSpan dureeMaint, List<Monstre> equipe, int id, bool maint, string natureMaint, int nbMinMonstre, string nom, bool ouvert, string typeDeBesoin, int MaxAttraction)
        {
            Console.WriteLine("Vous allez ajouter une nouvelle Attraction :");
            Attraction nouveau = new Attraction(besoinSpe, dureeMaint, equipe, id, maint, natureMaint, nbMinMonstre, nom, ouvert, typeDeBesoin);
            Console.WriteLine("L'attraction a bien été ajoutée");
            attractions.Add(nouveau);
            return nouveau;
        }

        public void IncrementerCagnotte(Monstre monstre, int montant)
        {
           
            Console.WriteLine("La modification est de :" + montant);
            monstre.Cagnotte += montant;
            Console.WriteLine("La nouvelle cagnotte est de", monstre.Cagnotte);
        }

        public void DecrementerCagnotte(Monstre monstre, int montant)
        {
            Console.WriteLine("Entrez le nombre de point à enlever de la cagnotte :");
            Console.WriteLine("La modification est de :" + "-" + montant);
            monstre.Cagnotte -= montant;
            Console.WriteLine("La nouvelle cagnotte est de", monstre.Cagnotte);
        }


        public void ModificationCagnotte(Monstre monstre,Administration admin)
        {

            if (monstre.Cagnotte < 50)
            {
                foreach (Attraction attract in admin.Attractions)
                {
                    if (attract is Boutique)
                    {
                        if ((attract as Boutique).Type == TypeBoutique.barbeApapa)
                        {
                            monstre.Affectation = attract.Nom;
                            break;
                        }
                    }
                }
           
            }
        }


        public void TriPersonnel(List<Personnel> liste)
        {
            liste.Sort();
            foreach (Personnel pers in toutLePersonnel)
            {
                Console.WriteLine(pers); //affiche tout le csv trier par nom car .sort appel les compareTo qui ont comme parametre un personnel. 
            }
        }

        public void TriMonstre() //Remplir liste de monstre avant de la trier
        {
            maListeMonstre.Sort();
                foreach (Monstre mons in MaListeMonstre)
            {
                Console.WriteLine(mons);
            }
        }
        

        public override string ToString()
        {
           string descri = base.ToString();
            descri += "Attractions : " + this.attractions + "ToutLePersonnel : " + this.toutLePersonnel;
            return descri;
        }
    }
}
