using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WAD_PetCare_7912_DAL.DBO
{
    public class Professional
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
        [Display(Name = "Date of Birth")]
        public DateTime DoB { get; set; }

        [Required]
        public string Education { get; set; }

        [Required]
        [Display(Name = "Work Experience")]
        public string WorkExperience { get; set; }

        [Required]
        public string Speciality { get; set; }
        //dropdown is planned to apply later

        [Required]
        [MinLength(9)]
        [Display(Name = "Phone No")]
        public string PhoneNo { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Address { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
    }
}
