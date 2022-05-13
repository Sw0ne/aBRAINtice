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
    /// Interaction logic for DeletionNotizWindow.xaml
    /// </summary>
    public partial class DeletionNotizWindow : Window
    {
        HomeWindow home;

        public DeletionNotizWindow(HomeWindow homeWindow)
        {
            InitializeComponent();

            home = homeWindow;
            this.Owner = home;

            this.ShowDialog().Equals(true);
        }

        private void ButtonJaDeleteNotiz_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonNeinDeleteNotiz_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
