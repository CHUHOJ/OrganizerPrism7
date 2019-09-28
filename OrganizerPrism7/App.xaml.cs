using OrganizerPrism7.UI.Views;
using Prism.Ioc;
using Prism.Modularity;
using System.Windows;
using Autofac;
using System;

namespace OrganizerPrism7.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App: Application
    {
        //protected override Window CreateShell()
        //{
        //    return Container.Resolve<MainWindow>();
        //}

        //protected override void RegisterTypes(IContainerRegistry containerRegistry)
        //{

        //}

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var bootstrapper = new Bootstrapper();
            var container = bootstrapper.Bootstrap();

            var mainWindow = container.Resolve<MainWindow>();
            mainWindow.Show();
        }

        private void Application_DispatcherUnhandledException(object sender,
            System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            MessageBox.Show("Unexpected error occured:" +
                Environment.NewLine + e.Exception.Message, "Unexpected error");

            e.Handled = true;
        }
    }
}
