using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Linq;
namespace Annotation
{
    class AnnotationsTest
    {
        public static void Display()
        {
            Console.WriteLine("Employee class Validations");
            Console.WriteLine("===========================");
            Employee objEmployee = new Employee();
            objEmployee.Name = "Sumitom";
            objEmployee.Age = 25;
            objEmployee.PhoneNumber = "9433430056";
            objEmployee.Email = "sumitomshome@gmail.com";
            ValidationContext context = new ValidationContext(objEmployee, null, null);
            List<ValidationResult> results = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(objEmployee, context, results, true);
            if (!valid)
            {
                foreach(ValidationResult TotalResult in results)
                {
                    Console.WriteLine("Member Name : {0}", TotalResult.MemberNames.First(), Environment.NewLine);
                    Console.WriteLine("Error Msg: {0}{1}", TotalResult.ErrorMessage, Environment.NewLine);
                }
            }
            else
            {
                Console.WriteLine("Name: " + objEmployee.Name + "\n" + "Age:" + objEmployee.Age + "\n" + "PhoneNumber:" + objEmployee.PhoneNumber + "\nEmail:" + objEmployee.Email);
            }
            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
        }
    }
}
