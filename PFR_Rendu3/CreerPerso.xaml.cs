using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using PFR;

namespace PFR_Rendu3
{
    /// <summary>
    /// Logique d'interaction pour CreerPerso.xaml
    /// </summary>
    public partial class CreerPerso : Window
    {
        Personnel nouv;
        Administration admin;
        List<Attraction> attractions;
        List<Personnel> toutLePersonnel;
        List<Monstre> maListeMonstre;

        public CreerPerso()
        {
            
            InitializeComponent();

            //initialisation
            nouv = new Personnel("", 00000, "", "", TypeSexe.autre);
           
            attractions = new List<Attraction>();
            toutLePersonnel = new List<Personnel>();
            maListeMonstre = new List<Monstre>();
            admin = new Administration(attractions, toutLePersonnel, maListeMonstre);

            //Déf du DataContext
            this.DataContext = nouv;
            toutLePersonnel.Add(nouv);

        }
  
        private void Valid_Click(object sender, RoutedEventArgs e)
        {
            nouv.Fonction = saisiFonction.Text;
            nouv.Matricule = int.Parse(saisiMatrice.Text);
            nouv.Nom = saisiNom.Text;
            nouv.Prenom = saisiPrenom.Text;
            
            switch (saisiSexe.Text)
            {
                case "male":
                    nouv.Sexe = TypeSexe.male;
                    break;
                case "femelle":
                    nouv.Sexe = TypeSexe.femelle;
                    break;
                case "autre":
                    nouv.Sexe = TypeSexe.autre;
                    break;

                default:
                    MessageBox.Show("Veuillez saisir 'male' 'femelle' ou 'autre'");
                    break;
            }
           

            MessageBox.Show("Identité : " + nouv);

        }

        private void ReInit_Click(object sender, RoutedEventArgs e)
        {
            nouv.Fonction = "";
            nouv.Matricule = 0;
            nouv.Nom = "";
            nouv.Prenom = "";
            nouv.Sexe = TypeSexe.autre;

            MessageBox.Show("Identité : " + nouv);
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {

            MainWindow window = new MainWindow();
            this.Close();
            window.Show();
        }
    }
}
