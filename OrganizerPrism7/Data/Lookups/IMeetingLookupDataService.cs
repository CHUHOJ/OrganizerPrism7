using OrganizerPrism7.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OrganizerPrism7.UI.Data.Lookups
{
    public interface IMeetingLookupDataService
    {
        Task<IEnumerable<LookupItem>> GetMeetingLookupAsync();
    }
}