using System;
using System.Collections.Generic;
using System.Text;

namespace WAD_PetCare_7912_DAL.Repositories
{
    public abstract class BaseRepo
    {
        protected readonly PetCareCenterDbContext _context;
        protected BaseRepo(PetCareCenterDbContext context)
        {
            _context = context;
        }
    }
}
