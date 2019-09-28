using System.Collections.Generic;
using System.Threading.Tasks;
using OrganizerPrism7.Model;

namespace OrganizerPrism7.UI.Data.Lookups
{
    public interface IProgrammingLanguageDataService
    {
        Task<IEnumerable<LookupItem>> GetProgrammingLanguageAsync();
    }
}