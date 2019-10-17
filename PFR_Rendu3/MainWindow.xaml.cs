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
using System.Windows.Navigation;
using System.Windows.Shapes;
using PFR;

namespace PFR_Rendu3
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
             
        }

        private void creer_Click(object sender, RoutedEventArgs e)
        {
            CreerPerso fenetre = new CreerPerso();
            this.Close(); //fermer 1ere fenetre
            fenetre.Show();
        }

        private void attraction_Click(object sender, RoutedEventArgs e)
        {
            CreerAttraction fenetre2 = new CreerAttraction();
            this.Close();
            fenetre2.Show();
        }
    }
}
