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
    /// Interaction logic for ChangeSpeicherortWindow.xaml
    /// </summary>
    public partial class ChangeSpeicherortWindow : Window
    {
        HomeWindow home;

        public ChangeSpeicherortWindow(HomeWindow homeWindow)
        {
            InitializeComponent();

            home = homeWindow;
            this.Owner = home;

            this.ShowDialog().Equals(true);
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
            this.Close();
        }

        private void ButtonAbbruchSpeicherort_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonFertigSpeicherort_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonSuchenSpeicherort_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
