using Microsoft.Practices.ServiceLocation;
using Microsoft.Practices.Unity;
using MovieDatabase.Interfaces;
using MovieDatabase.ViewModels;
using MovieDatabaseWinForms.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieDatabaseWinForms {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var container = new UnityContainer();
            container.RegisterInstance<IUnityContainer>(container);
            container.RegisterInstance<IWindowService>(new WindowService());
            container.RegisterInstance<IMessageBoxService>(new MessageBoxService());
            container.RegisterType<IView, AddForm>(typeof(AddViewModel).FullName);
            UnityServiceLocator locator = new UnityServiceLocator(container);
            ServiceLocator.SetLocatorProvider(() => locator);

            var splash = new SplashForm();
            splash.Show();
            var mf = new MainForm();
            mf.DataContext = new MainViewModel();
            splash.Close();
            Application.Run(mf);
        }
    }
}
