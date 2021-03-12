using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WAD_SRP_DRY_7912.Models;

namespace WAD_SRP_DRY_7912.DAL
{
    public class PetCareCenterDbContext: DbContext
    {
        public PetCareCenterDbContext(DbContextOptions<PetCareCenterDbContext> options) : 
            base(options)
        {

        }

        public virtual DbSet<Customer> Customers { get; set; }

        public virtual DbSet<Professional> Professionals { get; set; }
    }
}
