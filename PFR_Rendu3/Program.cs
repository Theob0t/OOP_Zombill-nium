using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Globalization;

namespace PFR
{
    class Program
    {

        static void RecuperationInfoPersonnel(string nomFichier)
        {

            List<Personnel> maListe = new List<Personnel>();
            List<Sorcier> maListeSorcier = new List<Sorcier>();
            List<Monstre> maListeMonstre = new List<Monstre>();
            List<Demon> maListeDemon = new List<Demon>();
            List<Fantome> maListeFantome = new List<Fantome>();
            List<LoupGarou> maListeLoup = new List<LoupGarou>();
            List<Vampire> maListeVampire = new List<Vampire>();
            List<Zombie> maListeZombie = new List<Zombie>();
            List<Attraction> maListeAttraction = new List<Attraction>();
            List<Boutique> maListeBoutique = new List<Boutique>();
            List<DarkRide> maListeDarkRide = new List<DarkRide>();
            List<RollerCoaster> maListeRollerCoaster = new List<RollerCoaster>();
            List<Spectacle> maListeSpectacle = new List<Spectacle>();

            //copier/coller du fichier disponible sur moodle
            StreamReader monStreamReader = new StreamReader(nomFichier); //ouvrir un fichier en flux d'entrée
            string ligne = monStreamReader.ReadLine(); //lire la première ligne du fichier


            while (ligne != null) //tant que la ligne lue n'est pas null --> encore des données
            {
                string[] temp = ligne.Split(';');//Découper selon le séparateur ';' --> on obtient un tableau de chaine

                //MONSTRE
                TypeSexe sex = TypeSexe.male; //par default male
                Enum.TryParse<TypeSexe>(temp[4], out sex);//car 4ieme indice du tab csv et modifie valeur sex par default

                //SORCIER
                Grade grade = Grade.novice; //par default novice
                Enum.TryParse<Grade>(temp[6], out grade);//6ieme indice et modifie val grade par default

                //ZOMBIE
                couleurZ couleur = couleurZ.bleuatre; //par default bleuatre
                Enum.TryParse<couleurZ>(temp[8], out couleur);//8ieme indice et modifie val grade par default

                //BOUTIQUE
                TypeBoutique typeb = TypeBoutique.souvenir;
                Enum.TryParse<TypeBoutique>(temp[6], out typeb);

                //ROLLERCOASTER
                TypeCategorie categorie = TypeCategorie.bobsleigh;
                Enum.TryParse<TypeCategorie>(temp[6], out categorie);

                //DATETIME
                //DateTime myDate;
                //DateTime.TryParse(temp[8], out myDate);

                string[] tempL = ligne.Split('-');//Découper selon le séparateur '-' pour recuperer les pouvoirs dans une liste

                //Liste Horaires
                string[] tempH = ligne.Split(' ');//Découper selon le séparateur ' ' pour recuperer les horaires dans une liste
                tempH.ToList();
                // List<DateTime> time = tempH.Select(date => DateTime.Parse(date)).ToList();

                switch (temp[0])
                {
                      case "Sorcier":
                           Console.WriteLine();  
                           foreach (string val in temp)
                           {
                               Console.Write("  " + val);
                           }
                           Sorcier sor = new Sorcier(temp[5], Convert.ToInt32(temp[1]), temp[2], temp[3], sex, grade,tempL.ToList());//aller chercher la case 5 / .ToList transforme en liste
                                                                                                                                     //alimenter la liste de téléphone
                           maListe.Add(sor);
                           maListeSorcier.Add(sor);
                           break;

                    case "Monstre":
                        Console.WriteLine();
                        foreach (string val in temp)
                        {
                            Console.Write(" " + val);
                        }

                        Monstre mon = new Monstre(temp[5], Int32.Parse(temp[1]), temp[2], temp[3], sex, Int32.Parse(temp[6]), temp[7]);//trouver fonction qui trouve lattraction grace a l'identifiant
                                                                                                                                       //alimenter la liste de monstre
                        maListe.Add(mon);
                        maListeMonstre.Add(mon);
                        break;


                    case "Demon":
                        Console.WriteLine();
                        foreach (string val in temp)
                        {
                            Console.Write(" " + val);
                        }

                        Demon dem = new Demon(temp[5], Int32.Parse(temp[1]), temp[2], temp[3], sex, Int32.Parse(temp[6]), temp[7], Int32.Parse(temp[8]), false);
                        maListe.Add(dem);
                        maListeDemon.Add(dem); break;

                    case "Fantome":
                        Console.WriteLine();
                        foreach (string val in temp)
                        {
                            Console.Write(" " + val);
                        }

                        Fantome fant = new Fantome(temp[5], Int32.Parse(temp[1]), temp[2], temp[3], sex, Int32.Parse(temp[6]), temp[7]);
                        maListe.Add(fant);
                        maListeFantome.Add(fant); break;

                    case "LoupGarou":
                        Console.WriteLine();
                        foreach (string val in temp)
                        {
                            Console.Write(" " + val);
                        }

                        LoupGarou lou = new LoupGarou(temp[5], Int32.Parse(temp[1]), temp[2], temp[3], sex, Int32.Parse(temp[6]), temp[7], Double.Parse(temp[8]));
                        maListe.Add(lou);
                        maListeLoup.Add(lou); break;

                    case "Vampire":
                        Console.WriteLine();
                        foreach (string val in temp)
                        {
                            Console.Write(" " + val);
                        }

                        Vampire vam = new Vampire(temp[5], Int32.Parse(temp[1]), temp[2], temp[3], sex, Int32.Parse(temp[6]), temp[7], Double.Parse(temp[8]));
                        maListe.Add(vam);
                        maListeVampire.Add(vam); break;

                    case "Zombie":
                        Console.WriteLine();
                        foreach (string val in temp)
                        {
                            Console.Write("  " + val);
                        }

                        Zombie zom = new Zombie(temp[5], Int32.Parse(temp[1]), temp[2], temp[3], sex, Int32.Parse(temp[6]), temp[7], Int32.Parse(temp[9]), couleur, false);
                        maListe.Add(zom);
                        maListeZombie.Add(zom); break;
                    case "Boutique":
                        Console.WriteLine();
                        foreach (string val in temp)
                        {
                            Console.Write(" " + val);
                        }

                        Boutique bou = new Boutique(temp[4], TimeSpan.Zero, null, Int32.Parse(temp[1]), false, temp[5], Int32.Parse(temp[3]), temp[2], true, temp[5], typeb);
                        maListeAttraction.Add(bou);
                        maListeBoutique.Add(bou); break;

                    case "DarkRide":
                        Console.WriteLine();
                        foreach (string val in temp)
                        {
                            Console.Write(" " + val);
                        }

                        DarkRide dark = new DarkRide(temp[4], TimeSpan.Zero, null, Int32.Parse(temp[1]), false, temp[5], Int32.Parse(temp[3]), temp[2], true, temp[5], TimeSpan.Zero, true);
                        maListeAttraction.Add(dark);
                        maListeDarkRide.Add(dark); break;

                    case "RollerCoaster":
                        Console.WriteLine();
                        foreach (string val in temp)
                        {
                            Console.Write(" " + val);
                        }

                        RollerCoaster roll = new RollerCoaster(temp[4], TimeSpan.Zero, null, Int32.Parse(temp[1]), false, temp[5], Int32.Parse(temp[3]), temp[2], true, temp[5], Int32.Parse(temp[7]), categorie, float.Parse(temp[8]));
                        maListeAttraction.Add(roll);
                        maListeRollerCoaster.Add(roll); break;

                    case "Spectacle":
                        Console.WriteLine();
                        foreach (string val in temp)
                        {
                            Console.Write(" " + val);
                        }
                        Spectacle spec = new Spectacle(temp[4], TimeSpan.Zero, null, Int32.Parse(temp[1]), false, "try", Int32.Parse(temp[3]), temp[2], true, temp[5], "00:00", Int32.Parse(temp[7]), temp[6]);
                        maListeAttraction.Add(spec);
                        maListeSpectacle.Add(spec); break;

                }
                ligne = monStreamReader.ReadLine();
            }
            monStreamReader.Close();

        }


        /*     static void AffichageListe(List<Personnel> liste)
           {
               foreach (Personnel x in liste)
               {
                   Console.WriteLine(x);
               }
           }
         static void Main(string[] args)
           {

               //Declarer 3 listes d'attraction pour pouvoir utiliser attraction

               List<Personnel> maListe = new List<Personnel>();
               List<Sorcier> maListeSorcier = new List<Sorcier>();
               List<Monstre> maListeMonstre = new List<Monstre>();
               List<Demon> maListeDemon = new List<Demon>();
               List<Fantome> maListeFantome = new List<Fantome>();
               List<LoupGarou> maListeLoup = new List<LoupGarou>();
               List<Vampire> maListeVampire = new List<Vampire>();
               List<Zombie> maListeZombie = new List<Zombie>();
               List<Attraction> maListeAttraction = new List<Attraction>();
               List<Boutique> maListeBoutique = new List<Boutique>();
               List<DarkRide> maListeDarkRide = new List<DarkRide>();
               List<RollerCoaster> maListeRollerCoaster = new List<RollerCoaster>();
               List<Spectacle> maListeSpectacle = new List<Spectacle>();
               List<Attraction> attract = new List<Attraction>();
               List<Personnel> perso = new List<Personnel>();
               List<Monstre> monstre = new List<Monstre>();
               List<Monstre> equipe = new List<Monstre>();
               Administration admin = new Administration(attract, perso,monstre);

               List<Personnel> toutLePersonnel = new List<Personnel>();


               RecuperationInfoPersonnel("Listing.csv");
               Console.WriteLine("  " + "\r\n" + "\r\n" + "\r\n" + "\r\n");
               Console.WriteLine();
               Personnel Marie = admin.AjoutPersonnel("Sorcier", 63785, "Dupont", "Jean", TypeSexe.male);
               Console.WriteLine(Marie);
               Console.WriteLine("  " + "\r\n");
               Personnel Jean = new Personnel("Sorcier", 26357, "Dupont", "Jean", TypeSexe.male);
               Jean.EvolutionPersonnel("Monstre");  //Exemple d'évolution d'un personnel (ici changement de fonction)
               Console.WriteLine(Jean+"   //Après évolution");
               Console.WriteLine("  " + "\r\n");
               TimeSpan duration = new TimeSpan(01);
               Attraction CrazyRide = admin.AjoutAttraction("false", duration, equipe, 34513, true, "--", 5, "CrazyRide", true, "--", 15);
               Console.WriteLine(CrazyRide);
               CrazyRide.EvolutionMaintenance(false);    //Exemple d'évolution d'une attraction (ici changement de la maintenance)
               Console.WriteLine(CrazyRide+ "   //Après évolution");
               Console.WriteLine("  " + "\r\n");
               Console.WriteLine("  " + "\r\n");


               Personnel Jeanne = new Personnel("Sorcier", 98538, "B", "Jeanne", TypeSexe.femelle);
               Personnel Quentin = new Personnel("Sorcier", 98538, "D", "Quentin", TypeSexe.male);
               Personnel Sarah = new Personnel("Monstre", 34749, "A", "Sarah", TypeSexe.femelle);
               Personnel Jack = new Personnel("Sorcier", 94558, "C", "Jack", TypeSexe.male);
               Personnel Paul = new Personnel("Monstre", 98368, "E", "Paul", TypeSexe.male);
               toutLePersonnel.Add(Jeanne);
               toutLePersonnel.Add(Quentin);
               toutLePersonnel.Add(Sarah);
               toutLePersonnel.Add(Jack);
               toutLePersonnel.Add(Paul);
               Console.WriteLine("Liste du Personnel non-trié : " + "\r\n");
               AffichageListe(toutLePersonnel);
               admin.TriPersonnel(toutLePersonnel);   //Fonction qui trie le personnel en fonction du nom
               Console.WriteLine("  " + "\r\n");
               Console.WriteLine("Liste du Personnel trié par nom :  " + "\r\n");
               AffichageListe(toutLePersonnel);
               Console.WriteLine("  " + "\r\n");

               List<Attraction> attractions = new List<Attraction>();
               Attraction Shop = new Attraction("false", duration, equipe, 34534, true, "--", 2, "Boutique", true, "--");
               attractions.Add(Shop);
               Monstre DarkVador = new Monstre("Monstre", 54321, "Dark", "Vador", TypeSexe.autre, 300, "Train Fantome");
               Console.WriteLine("Cagnotte avant modification de DarkVador :" + "\r\n" + DarkVador.Cagnotte);
               admin.IncrementerCagnotte(DarkVador, 50);
               Console.WriteLine(DarkVador.Cagnotte);

               Console.WriteLine("Cagnotte de DarkVador avant décrémentation :" + "\r\n" + DarkVador.Cagnotte);
               admin.DecrementerCagnotte(DarkVador, 325);
               Console.WriteLine(DarkVador.Cagnotte);
               Console.WriteLine(DarkVador.Affectation);
               admin.ModificationCagnotte(DarkVador, admin);
               // Console.WriteLine(DarkVador.Affectation);


               Zombie Zachary = new Zombie("Zombie", 12356, "Zakk", "Zachary", TypeSexe.male, 600, "Aux surprise de Satan", 5, couleurZ.bleuatre, false);
               Zombie.Invisibilite(Zachary);
               Console.WriteLine("La valeur de l'invisibilité est " + Zachary.Invisible);




               Console.ReadKey();
           }*/
    }
}
