using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WAD_PetCare_7912_DAL.DBO
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [MinLength(2)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [MinLength(9)]
        [Display(Name = "Phone No")]
        public string PhoneNo { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        [Display(Name = "No of Pets")]
        public int NoOfPets { get; set; }

        [Display(Name = "Professional")]

        public int? ProfessionalId { get; set; }

        public virtual Professional Professional { get; set; }

        public virtual ICollection<Pet> Pets { get; set; }
    }
}
