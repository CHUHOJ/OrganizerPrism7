using System;
using System.Threading.Tasks;
using OrganizerPrism7.DataAccess;
using OrganizerPrism7.Model;
using System.Data.Entity;

namespace OrganizerPrism7.UI.Data.Repositories
{
    public class ProgrammingLanguageRepository : GenericRepository<ProgrammingLanguage, OrganizerDbContext>, IProgrammingLanguageRepository
    {
        public ProgrammingLanguageRepository(OrganizerDbContext context) : base(context)
        {
        }

        public async Task<bool> IsReferencesByPersonAsync(int programmingLanguageId)
        {
            return await Context.Persons.AsNoTracking()
                .AnyAsync(x => x.FavouriteLanguageId == programmingLanguageId);
        }
    }
}
