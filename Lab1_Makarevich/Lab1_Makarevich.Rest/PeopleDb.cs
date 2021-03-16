using Lab1_Makarevich.Rest.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1_Makarevich.Rest
{
    public class PeopleDb : DbContext
    {
        public PeopleDb(DbContextOptions<PeopleDb> options)
            : base (options)
        {

        }

        public DbSet<Person> People { get; set; }
    }
}
