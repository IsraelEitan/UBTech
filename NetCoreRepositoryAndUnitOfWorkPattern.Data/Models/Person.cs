using System;
using System.Collections.Generic;

namespace NetCoreRepositoryAndUnitOfWorkPattern.Data.Models
{
    public partial class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Role { get; set; }
    }
}
