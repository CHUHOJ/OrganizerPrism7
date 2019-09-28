using OrganizerPrism7.Model;
using System.Threading.Tasks;

namespace OrganizerPrism7.UI.Data.Repositories
{
    public interface IPersonRepository : IGenericRepository<Person>
    {
        void RemovePhoneNumber(PersonPhoneNumber model);

        Task<bool> HasMeetingsAsync(int personId);
    }
}