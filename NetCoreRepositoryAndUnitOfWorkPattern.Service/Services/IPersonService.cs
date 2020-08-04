using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using NetCoreRepositoryAndUnitOfWorkPattern.Data.Models;

namespace NetCoreRepositoryAndUnitOfWorkPattern.Service.Services
{
    public interface IPersonService
    {
        List<Person> GetAll();
        Task<Person> GetById(int id);
        Task<Person> Add(Person newCustomer);
        List<Person> Find(Expression<Func<Person, bool>> predicate);
    }
}