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
           await Create(entity); //this the same code i will use for other repos )) will that be ok? yea
            //much simpler isnt it, maybe, i have no much experience in coding 
        }

        public async Task DeleteAsync(int id) //this also can be done? object ni ichidan Customers ni olish qiyinde 
            //hozi ok
        {
            var customer = await _context.Customers.FindAsync(id);
            //aaaa confused
            //Hurriyat you here?aha
            //nimaga add qilyotganda bunaq soramidi, not sure, workshopdan qiludim, that's ok
            //faqat qilinadganlani qb ketaman just one more try th
            _context.Customers.Remove(customer); //no idea (( for this
            
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
            await Update(entity);
            /*_context.Update(entity);
            await _context.SaveChangesAsync();*/
        }

        public bool Exists(int id)
        {
            return _context.Customers.Any(e => e.Id == id);
        }
    }
}
