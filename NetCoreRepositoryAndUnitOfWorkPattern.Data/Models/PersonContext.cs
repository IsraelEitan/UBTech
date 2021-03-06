﻿using Microsoft.EntityFrameworkCore;
using NetCoreRepositoryAndUnitOfWorkPattern.Data.Configuration;

namespace NetCoreRepositoryAndUnitOfWorkPattern.Data.Models
{
    public partial class PersonContext : DbContext
    {
        public PersonContext()
        {
        }

        public PersonContext(DbContextOptions<PersonContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Person> Person { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PersonConfiguration());

        }

    }
}
