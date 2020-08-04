using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using NetCoreRepositoryAndUnitOfWorkPattern.Data.Models;

namespace NetCoreRepositoryAndUnitOfWorkPattern.Data.Repositories
{
    public class PersonRepository : EFCoreRepository<Person>, IPersonRepository
    {
        private readonly PersonContext _myDBContext;

        public PersonRepository(PersonContext dbContext) : base(dbContext)
        {
            _myDBContext = dbContext;
        }

       // specific method
    }
}
