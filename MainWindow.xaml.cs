using stokieinventryapp.views;
using stokieinventryapp.Views;
using System.Windows;

namespace stokieinventryapp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainContent.Content = new DashboardView1();
        }

        private void Dashboard_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new DashboardView1();
        }

        private void Inventory_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new inventory1();
        }

        private void Suppliers_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new suppliers1();
        }

        private void Orders_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new productdetails1();
        }

        private void Reports_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new reports1();
        }

        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new settings1();
        }
    }
}
