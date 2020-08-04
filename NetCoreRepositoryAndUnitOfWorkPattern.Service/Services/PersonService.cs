using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NetCoreRepositoryAndUnitOfWorkPattern.Data.Models;
using NetCoreRepositoryAndUnitOfWorkPattern.Data.Repositories;

namespace NetCoreRepositoryAndUnitOfWorkPattern.Service.Services
{
    public class PersonService : IPersonService
    {
        private readonly IRepository<Person> _personRepository;

        public PersonService(IRepository<Person> customerRepository)
        {
            _personRepository = customerRepository;
        }

        public List<Person> GetAll()
        {
            return _personRepository.GetAll().ToList();
        }

        public async Task<Person> GetById(int id)
        {
            return await _personRepository.GetAll().FirstOrDefaultAsync(x => x.Id == id);
        }

        public List<Person> Find(Expression<Func<Person, bool>> predicate)
        {
            return _personRepository.Find(predicate).ToList();
        }

        public async Task<Person> Add(Person newCustomer)
        {
            return await _personRepository.AddAsync(newCustomer);
        }

    }
}