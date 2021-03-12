using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WAD_PetCare_7912_DAL.DBO;

namespace WAD_PetCare_7912_DAL.Repositories
{
    public class CustomerRepo : BaseRepo, IRepository<Customer>
    {
        public CustomerRepo(PetCareCenterDbContext context):base(context)
        {
        }
        public async Task CreateAsync(Customer entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var customer = await _context.Customers.FindAsync(id);
            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Customer>> GetAllAsync()
        {
            return await _context.Customers.Include(p => p.Professional).ToListAsync();
        }

        public async Task<Customer> GetByIdAsync(int id)
        {
            return await _context.Customers
                .Include(c => c.Professional)
                .FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task UpdateAsync(Customer entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }

        public bool Exists(int id)
        {
            return _context.Customers.Any(e => e.Id == id);
        }
    }
}
