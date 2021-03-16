using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WAD_PetCare_7912_DAL.DBO;

namespace WAD_PetCare_7912_DAL
{
    public class PetCareCenterDbContext: DbContext
    {
        public PetCareCenterDbContext(DbContextOptions<PetCareCenterDbContext> options) : 
            base(options)
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }

        public virtual DbSet<Professional> Professionals { get; set; }

        public virtual DbSet<Pet> Pets { get; set; }
    }
}
