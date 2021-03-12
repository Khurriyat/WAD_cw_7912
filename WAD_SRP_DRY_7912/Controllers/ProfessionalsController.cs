using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WAD_PetCare_7912_DAL;
using WAD_PetCare_7912_DAL.DBO;
using WAD_PetCare_7912_DAL.Repositories;

namespace WAD_SRP_DRY_7912.Controllers
{
    public class ProfessionalsController : Controller
    {
        private readonly IRepository<Professional> _professionalRepo;

        public ProfessionalsController(IRepository<Professional> professionalRepo)
        {
            _professionalRepo = professionalRepo;
        }

        // GET: Professionals
        public async Task<IActionResult> Index()
        {
            return View(await _professionalRepo.GetAllAsync());
        }

        // GET: Professionals/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var professional = await _professionalRepo.GetByIdAsync(id.Value);
            if (professional == null)
            {
                return NotFound();
            }

            return View(professional);
        }

        // GET: Professionals/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Professionals/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,DoB,Education,WorkExperience,Speciality,PhoneNo,Email,Address")] Professional professional)
        {
            if (ModelState.IsValid)
            {
                await _professionalRepo.CreateAsync(professional);
                return RedirectToAction(nameof(Index));
            }
            return View(professional);
        }

        // GET: Professionals/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var professional = await _professionalRepo.GetByIdAsync(id.Value);
            if (professional == null)
            {
                return NotFound();
            }
            return View(professional);
        }

        // POST: Professionals/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,DoB,Education,WorkExperience,Speciality,PhoneNo,Email,Address")] Professional professional)
        {
            if (id != professional.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _professionalRepo.UpdateAsync(professional);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_professionalRepo.Exists(professional.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(professional);
        }

        // GET: Professionals/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var professional = await _professionalRepo.GetByIdAsync(id.Value);
            if (professional == null)
            {
                return NotFound();
            }

            return View(professional);
        }

        // POST: Professionals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _professionalRepo.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
