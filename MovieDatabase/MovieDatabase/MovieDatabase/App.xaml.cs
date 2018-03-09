using Microsoft.Practices.ServiceLocation;
using Microsoft.Practices.Unity;
using MovieDatabase.Interfaces;
using MovieDatabase.WpfViews.Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MovieDatabase.WpfViews {
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application {
        protected override void OnStartup(StartupEventArgs e) {
            base.OnStartup(e);
        }
    }
}
