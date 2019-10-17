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
    /// Logique d'interaction pour CreerAttraction.xaml
    /// </summary>
    public partial class CreerAttraction : Window
    {
        Attraction attract ;
        Administration admin;
        List<Attraction> attractions;
        List<Personnel> toutLePersonnel;
        List<Monstre> maListeMonstre;

        public CreerAttraction()
        {
            InitializeComponent();

            //initialisation
            attract = new Attraction("", TimeSpan.Zero,maListeMonstre, 0, false, "", 0, "", false, "");

            attractions = new List<Attraction>();
            toutLePersonnel = new List<Personnel>();
            maListeMonstre = new List<Monstre>();
            admin = new Administration(attractions, toutLePersonnel, maListeMonstre);

            //Déf du DataContext
            this.DataContext = attract;
            attractions.Add(attract);
        }

        private void Valid_Click(object sender, RoutedEventArgs e)
        {
            attract.BesoinSpecifique = saisiBesoin.Text;
            attract.DureeMaintenance = TimeSpan.Parse(saisiDuree.Text);
            //attract.Equipe = tempL.ToList();
            attract.Identifiant =int.Parse(saisiId.Text);
            switch (saisiMaint.Text)
            {
                case "true":
                    attract.Maintenance=true;
                    break;
                case "false":
                    attract.Maintenance = false;
                    break;
                default:
                    MessageBox.Show("Veuillez saisir 'true' ou 'false'");
                    break;
            }
            attract.NatureMaintenance = saisiNat.Text;
            attract.NbMinMonstre =int.Parse(saisiMini.Text);
            attract.Nom = saisiNom.Text;
            switch (saisiOuv.Text)
            {
                case "true":
                    attract.Ouvert = true;
                    break;
                case "false":
                    attract.Ouvert = false;
                    break;
                default:
                    MessageBox.Show("Veuillez saisir 'true' ou 'false'");
                    break;
            }
            attract.TypeDeBesoin = saisiType.Text;
   

            MessageBox.Show("Identité : " + attract);

        }

        private void ReInit_Click(object sender, RoutedEventArgs e)
        {
            attract.BesoinSpecifique ="";
            attract.DureeMaintenance = TimeSpan.Zero;
            attract.Equipe = maListeMonstre;
            attract.Identifiant =0;
            attract.Maintenance =false;
            attract.NatureMaintenance ="";
            attract.NbMinMonstre=0;
            attract.Nom ="";
            attract.Ouvert =false;
            attract.TypeDeBesoin ="";

            MessageBox.Show("Identité : " + attract);
        }

        private void Menu_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            this.Close();
            window.Show();
            
        }
    }
}
