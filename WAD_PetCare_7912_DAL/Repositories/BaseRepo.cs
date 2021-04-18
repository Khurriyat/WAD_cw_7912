using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WAD_PetCare_7912_DAL.Repositories
{
    public abstract class BaseRepo
    {
        protected readonly PetCareCenterDbContext _context;
        protected BaseRepo(PetCareCenterDbContext context)
        {
            _context = context;
        }
        public async Task Create(object entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(object entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }
        
    }
}
