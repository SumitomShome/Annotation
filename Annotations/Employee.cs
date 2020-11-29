using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace Annotation
{
    class Employee
    {
        [Required(ErrorMessage = "Employee {0} is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Name should have minimum of 3 characters and maximum of 100 characters")]
        [DataType(DataType.Text)]
        public string Name { get; set; }
        [Range(18, 100, ErrorMessage = "Age should be above 18 and less than 100")]
        public int Age { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Phone]
        public string PhoneNumber { get; set; }
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }
    }
}
