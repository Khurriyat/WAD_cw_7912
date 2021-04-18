using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WAD_PetCare_7912_DAL.DBO;

namespace WAD_PetCare_7912_DAL.Repositories
{
    public class PetRepo : BaseRepo, IRepository<Pet>
    {
        public PetRepo(PetCareCenterDbContext context) : base(context)
        {
        }

        public async Task CreateAsync(Pet entity)
        {
            await Create(entity);
        }

        public async Task DeleteAsync(int id)
        {
            var pet = await _context.Pets.FindAsync(id);
            _context.Pets.Remove(pet);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Pet>> GetAllAsync()
        {
            return await _context.Pets.Include(p => p.Customer).ToListAsync();
        }

        public async Task<Pet> GetByIdAsync(int id)
        {
            return await _context.Pets
                .Include(c => c.Customer)
                .FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task UpdateAsync(Pet entity)
        {
            await Update(entity);
        }

        public bool Exists(int id)
        {
            return _context.Pets.Any(e => e.Id == id);
        }
    }
}
