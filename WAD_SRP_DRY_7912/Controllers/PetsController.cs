using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WAD_PetCare_7912_DAL;
using WAD_PetCare_7912_DAL.DBO;
using WAD_PetCare_7912_DAL.Repositories;

namespace WAD_PetCare_7912.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetsController : ControllerBase
    {
        private readonly IRepository<Pet> _petRepo;
        private readonly IRepository<Customer> _customerRepo;

        public PetsController(IRepository<Pet> petRepo,
            IRepository<Customer> customerRepo)
        {
            _petRepo = petRepo;
            _customerRepo = customerRepo;
        }

        // GET: api/Pets
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pet>>> GetPets()
        {
            return await _petRepo.GetAllAsync();
        }

        // GET: api/Pets/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Pet>> GetPet(int id)
        {
            var pet = await _petRepo.GetByIdAsync(id);

            if (pet == null)
            {
                return NotFound();
            }

            return pet;
        }

        // PUT: api/Pets/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPet(int id, Pet pet)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pet.Id)
            {
                return BadRequest();
            }

            try
            {
                await _petRepo.UpdateAsync(pet);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_petRepo.Exists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }           

            return NoContent();
        }

        // POST: api/Pets
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Pet>> PostPet(Pet pet)
        {           
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _petRepo.CreateAsync(pet);

            return CreatedAtAction("GetPet", new { id = pet.Id }, pet);
        }

        // DELETE: api/Pets/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Pet>> DeletePet(int id)
        {
            var pet = await _petRepo.GetByIdAsync(id);
            if (pet == null)
            {
                return NotFound();
            }

            await _petRepo.DeleteAsync(id);

            return pet;
        }
    }
}
