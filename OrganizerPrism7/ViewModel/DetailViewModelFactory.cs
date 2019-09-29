using System;

namespace OrganizerPrism7.UI.ViewModel
{
    public interface IDetailViewModelFactory
    {
        IDetailViewModel GetDetailViewModel(string detailViewModelName);
    }


    public class DetailViewModelFactory : IDetailViewModelFactory
    {
        private readonly Func<IPersonDetailViewModel> _personDetailVMCreator;

        private readonly Func<IMeetingDetailViewModel> _meetingDetailVMCreator;

        private readonly Func<IProgrammingLanguageDetailViewModel> _programmingLanguageVMCreator;

        public DetailViewModelFactory(Func<IPersonDetailViewModel> personDetailVMCreator, Func<IMeetingDetailViewModel> meetingDetailVMCreator, Func<IProgrammingLanguageDetailViewModel> programmingLanguageVMCreator)
        {
            _personDetailVMCreator = personDetailVMCreator;
            _meetingDetailVMCreator = meetingDetailVMCreator;
            _programmingLanguageVMCreator = programmingLanguageVMCreator;
        }

        public IDetailViewModel GetDetailViewModel(string detailViewModelName)
        {
            IDetailViewModel vm;

            switch (detailViewModelName)
            {
                case nameof(MeetingDetailViewModel):
                    vm = _meetingDetailVMCreator();
                    break;
                case nameof(PersonDetailViewModel):
                    vm = _personDetailVMCreator();
                    break;
                case nameof(ProgrammingLanguageDetailViewModel):
                    vm = _programmingLanguageVMCreator();
                    break;
                default:
                    vm = null;
                    break;
            }

            return vm;
        }
    }
}
