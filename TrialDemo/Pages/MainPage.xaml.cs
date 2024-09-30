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

namespace TrialDemo.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void AdminBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {

            }
            catch
            {
                MessageBox.Show("Произошла ошибка.");
            }
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Application.Current.Shutdown();
            }
            catch
            {
                MessageBox.Show("Произошла ошибка.");
            }
        }

        private void ServicesBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                NavigationService.Navigate(new ServicesPage());
            }
            catch
            {
                MessageBox.Show("Произошла ошибка.");
            }
        }
    }
}
