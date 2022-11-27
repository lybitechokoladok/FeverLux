using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using FeverluxApp.WPF.Views;

namespace FeverluxApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            Window window = new LoginView();
            window.Show();

            window.IsVisibleChanged += (s, ev) =>
            {
                if (window.IsVisible == false && window.IsLoaded)
                {
                    var mainView = new MainView();
                    mainView.Show();
                    window.Close();
                }
            };

            base.OnStartup(e);
        }
    }
}
