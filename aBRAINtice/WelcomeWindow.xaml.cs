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

namespace aBRAINtice
{
    /// <summary>
    /// Interaction logic for DeletionWindow.xaml
    /// </summary>
    public partial class WelcomeWindow : Window
    {
        public WelcomeWindow()
        {
            InitializeComponent();

            Gruss();
            // Check if User in DB Methode

            
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void WeiterButton_Click(object sender, RoutedEventArgs e)
        {
            //this.Hide();
            //HomeWindow homeWindow = new HomeWindow(this);
            //homeWindow.Show();
        }

        private void NeuesKonto_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            UserWindow userWindow = new UserWindow(this);
            userWindow.Show();
        }

        private void WelcomeWindow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                DragMove();
            }
        }

        // ANZEIGE DES GRUSSES (JE NACH TAGESZEIT)
        public void Gruss()
        {
            if (DateTime.Now.Hour >= 4 && DateTime.Now.Hour < 12)
            {
                GrussBlockTageszeit.Text = "Guten Morgen, ";
            }
            else if (DateTime.Now.Hour >= 12 && DateTime.Now.Hour <= 17)
            {
                GrussBlockTageszeit.Text = "Guten Mittag, ";
            }
            else if (DateTime.Now.Hour >= 18 && DateTime.Now.Hour <= 23)
            {
                GrussBlockTageszeit.Text = "Guten Abend, ";
            }
            else
            {
                GrussBlockTageszeit.Text = "Gute Nacht, ";
            }
        }
    }
}
