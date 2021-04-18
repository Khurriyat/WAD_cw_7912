using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WAD_PetCare_7912_DAL.DBO;

namespace WAD_PetCare_7912_DAL.Repositories
{
    public class ProfessionalRepo : BaseRepo, IRepository<Professional>
    {
        public ProfessionalRepo(PetCareCenterDbContext context):base(context)
        {
        }

        public async Task CreateAsync(Professional entity)
        {
            await Create(entity);
        }

        public async Task DeleteAsync(int id)
        {
            var professional = await _context.Professionals.FindAsync(id);
            _context.Professionals.Remove(professional);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Professional>> GetAllAsync()
        {
           return await _context.Professionals.ToListAsync();
        }

        public async Task<Professional> GetByIdAsync(int id)
        {
            return await _context.Professionals
                .FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task UpdateAsync(Professional entity)
        {
            await Update(entity);
        }

        public bool Exists(int id)
        {
            return _context.Professionals.Any(e => e.Id == id);
        }
    }
}
