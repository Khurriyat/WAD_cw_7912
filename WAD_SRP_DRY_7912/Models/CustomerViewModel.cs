using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WAD_PetCare_7912_DAL.DBO;

namespace WAD_PetCare_7912.Models
{
    public class CustomerViewModel: Customer
    {
        public SelectList Professionals { get; set; }
        public void CopyFromCustomer(Customer c)
        {
            Id = c.Id;
            FirstName = c.FirstName;
            LastName = c.LastName;
            PhoneNo = c.PhoneNo;
            Email = c.Email;
            Address = c.Address;
            NoOfPets = c.NoOfPets;
            ProfessionalId = c.ProfessionalId;
        }
    }
}
