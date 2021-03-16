using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WAD_PetCare_7912_DAL.DBO
{
    public class Pet
    {
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Pet Type")]
        public PetType PetType { get; set; }

        [Display(Name = "Customer")]
        public int? CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
