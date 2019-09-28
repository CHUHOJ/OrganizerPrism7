using System.Threading.Tasks;
using OrganizerPrism7.Model;
using System.Collections.Generic;

namespace OrganizerPrism7.UI.Data.Repositories
{
    public interface IMeetingRepository : IGenericRepository<Meeting>
    {
        Task<List<Person>> GetAllPersonsAsync();
        Task ReloadPersonAsync(int personId);
    }
}