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
    /// Interaction logic for NewANWindow.xaml
    /// </summary>
    public partial class NewANWindow : Window
    {
        HomeWindow home;

        public NewANWindow(HomeWindow homeWindow)
        {
            InitializeComponent();

            home = homeWindow;
        }

        private void ButtonSaveBericht_Click(object sender, RoutedEventArgs e)
        {

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

        private void ButtonAbbruchBericht_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            home.Show();
        }
    }
}
