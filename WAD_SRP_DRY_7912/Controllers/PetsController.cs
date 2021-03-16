using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WAD_PetCare_7912_DAL;
using WAD_PetCare_7912_DAL.DBO;
using WAD_PetCare_7912_DAL.Repositories;

namespace WAD_PetCare_7912.Controllers
{
    public class PetsController : Controller
    {
        private readonly IRepository<Pet> _petRepo;
        private readonly IRepository<Customer> _customerRepo;

        public PetsController(IRepository<Pet> petRepo,
            IRepository<Customer> customerRepo)
        {
            _petRepo = petRepo;
            _customerRepo = customerRepo;
        }

        // GET: Pets
        public async Task<IActionResult> Index()
        {
            return View(await _petRepo.GetAllAsync());
        }

        // GET: Pets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pet = await _petRepo.GetByIdAsync(id.Value);
            if (pet == null)
            {
                return NotFound();
            }

            return View(pet);
        }

        // GET: Pets/Create
        public async Task<IActionResult> Create()
        {
            ViewData["CustomerId"] = new SelectList(await _customerRepo.GetAllAsync(), "Id", "FirstName");
            return View();
        }

        // POST: Pets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,PetType,CustomerId")] Pet pet)
        {
            if (ModelState.IsValid)
            {
                await _petRepo.CreateAsync(pet);
                return RedirectToAction(nameof(Index));
            }
            ViewData["CustomerId"] = new SelectList(await _customerRepo.GetAllAsync(), "Id", "FirstName", pet.CustomerId);
            return View(pet);
        }

        // GET: Pets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pet = await _petRepo.GetByIdAsync(id.Value);
            if (pet == null)
            {
                return NotFound();
            }
            ViewData["CustomerId"] = new SelectList(await _customerRepo.GetAllAsync(), "Id", "FirstName", pet.CustomerId);
            return View(pet);
        }

        // POST: Pets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,PetType,CustomerId")] Pet pet)
        {
            if (id != pet.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _petRepo.UpdateAsync(pet);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_petRepo.Exists(pet.Id))
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
            ViewData["CustomerId"] = new SelectList(await _customerRepo.GetAllAsync(), "Id", "FirstName", pet.CustomerId);
            return View(pet);
        }

        // GET: Pets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pet = await _petRepo.GetByIdAsync(id.Value);
            if (pet == null)
            {
                return NotFound();
            }

            return View(pet);
        }

        // POST: Pets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _petRepo.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
