using OrganizerPrism7.Model;
using System.Threading.Tasks;

namespace OrganizerPrism7.UI.Data.Repositories
{
    public interface IProgrammingLanguageRepository : IGenericRepository<ProgrammingLanguage>
    {
        Task<bool> IsReferencesByPersonAsync(int programmingLanguageId);
    }
}
