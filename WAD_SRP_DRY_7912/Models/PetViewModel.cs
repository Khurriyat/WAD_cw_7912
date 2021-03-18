using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WAD_PetCare_7912_DAL.DBO;

namespace WAD_PetCare_7912.Models
{
    public class PetViewModel: Pet
    {
        public SelectList Customers { get; set; }

        public void CopyFromPet(Pet p)
        {
            Id = p.Id;
            Name = p.Name;
            PetType = p.PetType;
            CustomerId = p.CustomerId;
        }
    }
}
