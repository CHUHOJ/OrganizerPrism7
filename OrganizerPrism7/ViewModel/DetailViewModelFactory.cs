
using Prism.Events;
using OrganizerPrism7.UI.Data.Lookups;
using OrganizerPrism7.UI.Data.Repositories;
using OrganizerPrism7.UI.Views.Services;

namespace OrganizerPrism7.UI.ViewModel
{
    public interface IDetailViewModelFactory
    {
        IDetailViewModel GetDetailViewModel(string detailViewModelName);
    }


    public class DetailViewModelFactory : IDetailViewModelFactory
    {
        IEventAggregator _eventAggregator;
        IMessageDialogService _messageDialogService;
        IMeetingRepository _meetingRepository;
        IPersonRepository _personRepository;
        IProgrammingLanguageRepository _programmingLanguageRepository;
        IProgrammingLanguageDataService _programmingLanguageDataService;

        public DetailViewModelFactory(IEventAggregator ea, IMessageDialogService messageDialogService, 
            IMeetingRepository meetingRepository,IPersonRepository personRepository, IProgrammingLanguageRepository programmingLanguageRepository,
            IProgrammingLanguageDataService programmingLanguageDataService)
        {
            _eventAggregator = ea;
            _messageDialogService = messageDialogService;
            _meetingRepository = meetingRepository;
            _personRepository = personRepository;
            _programmingLanguageRepository = programmingLanguageRepository;
            _programmingLanguageDataService = programmingLanguageDataService;
        }

        public IDetailViewModel GetDetailViewModel(string detailViewModelName)
        {
            IDetailViewModel vm;

            switch (detailViewModelName)
            {
                case nameof(MeetingDetailViewModel):
                    vm = new MeetingDetailViewModel(_eventAggregator,_messageDialogService, _meetingRepository);
                    break;
                case nameof(PersonDetailViewModel):
                    vm = new PersonDetailViewModel(_personRepository,_eventAggregator,_messageDialogService,_programmingLanguageDataService);
                    break;
                case nameof(ProgrammingLanguageDetailViewModel):
                    vm = new ProgrammingLanguageDetailViewModel(_eventAggregator,_messageDialogService,_programmingLanguageRepository);
                    break;
                default:
                    vm = null;
                    break;
            }

            return vm;
        }
    }
}
