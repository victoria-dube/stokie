using SQLitePCL;
using stokieinventryapp.Data;
using stokieinventryapp.Models;
using stokieinventryapp.Views;
using System.Windows;


namespace stokieinventryapp
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            // VERY IMPORTANT
            Batteries.Init();

            // Initialize database (creates tables)
            var db = new DatabaseHelper();

            base.OnStartup(e);

            var login = new Views.login();
            login.Show();
        }
    }
}

           
    

