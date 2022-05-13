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

namespace aBRAINtice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class HomeWindow : Window
    {
        WelcomeWindow welcome;

        public HomeWindow() // WelcomeWindow welcomeWindow
        {
            //welcome = welcomeWindow;

            InitializeComponent();

        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                DragMove();
            }
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ButtonBerichtNeu_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            var newAN = new NewANWindow(this);
            newAN.Show();
        }

        private void ButtonNotizNeu_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonBearbeiten_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonBerichtPdf_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonDeleteBericht_Click(object sender, RoutedEventArgs e)
        {
            var deletionBericht = new DeletionBerichtWindow(this);
        }

        private void ButtonDeleteNotiz_Click(object sender, RoutedEventArgs e)
        {
            var deletionNotiz = new DeletionNotizWindow(this);
        }

        private void ButtonChangeSpeicherort_Click(object sender, RoutedEventArgs e)
        {
            var changeSpeicherort = new ChangeSpeicherortWindow(this);
        }

        private void ButtonMenu_Click(object sender, RoutedEventArgs e)
        {
            //this.Close();
            //welcome.Show();
        }

    }
}
