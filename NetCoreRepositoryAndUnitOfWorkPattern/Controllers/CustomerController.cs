using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreRepositoryAndUnitOfWorkPattern.Data.Models;
using NetCoreRepositoryAndUnitOfWorkPattern.Service.Services;

namespace NetCoreRepositoryAndUnitOfWorkPattern.Controllers
{
    public class PersonController
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        public async Task<ActionResult<Person>> Create()
        {
            var person = new Person
            {
                Age = 30,
                FirstName = "Wolfgang",
                LastName = "Ofner",
                Role = "Role"
            };

            return await _personService.Add(person);
        }

        public ActionResult<List<Person>> GetAll()
        {
            return _personService.GetAll();
        }

        public async Task<ActionResult<Person>> GetById()
        {
            return await _personService.GetById(1);
        }
    }
}