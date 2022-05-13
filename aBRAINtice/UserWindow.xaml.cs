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
    /// Interaction logic for UserWindow.xaml
    /// </summary>
    public partial class UserWindow : Window
    {
        WelcomeWindow welcome;

        public UserWindow(WelcomeWindow welcomeWindow)
        {
            welcome = welcomeWindow;

            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                DragMove();
            }
        }

        private void DasBinIchButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            welcome.Show();
        }

        private void AbbrechenButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            welcome.Show();
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
