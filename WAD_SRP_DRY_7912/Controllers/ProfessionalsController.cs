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
    public class ProfessionalsController : ControllerBase
    {
        private readonly IRepository<Professional> _professionalRepo;

        public ProfessionalsController(IRepository<Professional> professionalRepo)
        {
            _professionalRepo = professionalRepo;
        }

        // GET: api/Professionals
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Professional>>> GetProfessionals()
        {
            return await _professionalRepo.GetAllAsync();
        }

        // GET: api/Professionals/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Professional>> GetProfessional(int id)
        {
            var professional = await _professionalRepo.GetByIdAsync(id);

            if (professional == null)
            {
                return NotFound();
            }

            return professional;
        }

        // PUT: api/Professionals/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProfessional(int id, Professional professional)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != professional.Id)
            {
                return BadRequest();
            }

            try
            {
                await _professionalRepo.UpdateAsync(professional);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_professionalRepo.Exists(id))
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

        // POST: api/Professionals
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Professional>> PostProfessional(Professional professional)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _professionalRepo.CreateAsync(professional);

            return CreatedAtAction("GetProfessional", new { id = professional.Id }, professional);
        }

        // DELETE: api/Professionals/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Professional>> DeleteProfessional(int id)
        {
            var professional = await _professionalRepo.GetByIdAsync(id);
            if (professional == null)
            {
                return NotFound();
            }

            await _professionalRepo.DeleteAsync(id);

            return professional;
        }
    }
}
