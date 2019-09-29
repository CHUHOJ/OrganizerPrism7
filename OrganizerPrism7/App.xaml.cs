using OrganizerPrism7.UI.Views;
using Prism.Ioc;
using Prism.Modularity;
using System.Windows;
using OrganizerPrism7.DataAccess;
using OrganizerPrism7.UI.Data.Lookups;
using OrganizerPrism7.UI.Data.Repositories;
using OrganizerPrism7.UI.Views.Services;
using OrganizerPrism7.UI.ViewModel;
using Prism.Events;

namespace OrganizerPrism7.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();

        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<OrganizerDbContext>();
            containerRegistry.Register<IMessageDialogService, MessageDialogService>();
            containerRegistry.Register<INavigationViewModel, NavigationViewModel>();

            containerRegistry.Register<IMeetingLookupDataService, LookupDataService>();
            containerRegistry.Register<IPersonLookupDataService, LookupDataService>();
            containerRegistry.Register<IProgrammingLanguageDataService, LookupDataService>();
            containerRegistry.Register<IPersonRepository, PersonRepository>();
            containerRegistry.Register<IMeetingRepository, MeetingRepository>();
            containerRegistry.Register<IProgrammingLanguageRepository, ProgrammingLanguageRepository>();

            containerRegistry.Register<IMeetingDetailViewModel, MeetingDetailViewModel>();
            containerRegistry.Register<IPersonDetailViewModel, PersonDetailViewModel>();
            containerRegistry.Register<IProgrammingLanguageDetailViewModel, ProgrammingLanguageDetailViewModel>();
            containerRegistry.Register<IDetailViewModelFactory, DetailViewModelFactory>();

        }


    }
}
