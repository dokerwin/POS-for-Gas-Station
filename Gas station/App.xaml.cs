using CefSharp;
using CefSharp.Wpf;
using Gas_station.PrepareStation;
using Gas_station.Util.Pdf;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;

namespace Gas_station
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        void App_Startup(object sender, StartupEventArgs e)
        {
            InitStation init = new InitStation();
        }
        
    }
}
