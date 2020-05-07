using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorFormValidation.Data
{
    public class Employee
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        [StringLength(5,MinimumLength = 5, ErrorMessage ="Postal Code must be 5 char long")]
        public string PostalCode { get; set; }

        public string Phone { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage ="Salary is required")]
        [Range(1000, 9999999, ErrorMessage ="Salary should be grater than 1000$")]
        public decimal Salary { get; set; }
    }
}
