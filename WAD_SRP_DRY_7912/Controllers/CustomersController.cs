using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WAD_PetCare_7912.Models;
using WAD_PetCare_7912_DAL;
using WAD_PetCare_7912_DAL.DBO;
using WAD_PetCare_7912_DAL.Repositories;

namespace WAD_PetCare_7912.Controllers
{
    public class CustomersController : Controller
    {
        private readonly IRepository<Customer> _customerRepo;
        private readonly IRepository<Professional> _professionalRepo;

        public CustomersController(IRepository<Customer> customerRepo,
            IRepository<Professional> professionalRepo)
        {
            _customerRepo = customerRepo;
            _professionalRepo = professionalRepo;
        }

        // GET: Customers
        public async Task<IActionResult> Index()
        {
            return View(await _customerRepo.GetAllAsync());
        }


        // GET: Customers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _customerRepo.GetByIdAsync(id.Value);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // GET: Customers/Create
        public async Task<IActionResult> Create()
        {
            var cutomerViewModel = new CustomerViewModel();
            cutomerViewModel.Professionals = new SelectList(await _professionalRepo.GetAllAsync(), "Id", "FirstName");
            return View(cutomerViewModel);
        }

        // POST: Customers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,PhoneNo,Email,Address,NoOfPets,ProfessionalId")] CustomerViewModel customer)
        {
            if (ModelState.IsValid)
            {
                await _customerRepo.CreateAsync(customer);
                return RedirectToAction(nameof(Index));
            }
            customer.Professionals = new SelectList(await _professionalRepo.GetAllAsync(), "Id", "FirstName", customer.ProfessionalId);
            return View(customer);
        }

        // GET: Customers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _customerRepo.GetByIdAsync(id.Value);
            if (customer == null)
            {
                return NotFound();
            }
            var customerViewModel = new CustomerViewModel();
            customerViewModel.CopyFromCustomer(customer);
            customerViewModel.Professionals = new SelectList(await _professionalRepo.GetAllAsync(), "Id", "FirstName", customer.ProfessionalId);
            return View(customerViewModel);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,PhoneNo,Email,Address,NoOfPets,ProfessionalId")] CustomerViewModel customer)
        {
            if (id != customer.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    await _customerRepo.UpdateAsync(customer);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_customerRepo.Exists(customer.Id))
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
            customer.Professionals = new SelectList(await _professionalRepo.GetAllAsync(), "Id", "FirstName", customer.ProfessionalId);
            return View(customer);
        }

        // GET: Customers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _customerRepo.GetByIdAsync(id.Value);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _customerRepo.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
