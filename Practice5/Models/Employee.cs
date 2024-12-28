using System.ComponentModel.DataAnnotations;

namespace BasicAuth.Models
{
    public class Employee
    {

        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public bool IsActive { get; set; }

        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>()
            {
            new Employee { Id = 1, FirstName = "Ali", LastName = "Doe", Gender = "Male", City = "Karachi", IsActive = true },
            new Employee { Id = 2, FirstName = "Hussain", LastName = "Smith", Gender = "Male", City = "Lahore", IsActive = true },
            new Employee { Id = 3, FirstName = "Hasan", LastName = "Brown", Gender = "Male", City = "Karachi", IsActive = false },
            new Employee { Id = 4, FirstName = "Mohsin", LastName = "Davis", Gender = "Male", City = "Karachi", IsActive = true },
            new Employee { Id = 5, FirstName = "Mesum", LastName = "Wilson", Gender = "Male", City = "Lahore", IsActive = false },
            new Employee { Id = 6, FirstName = "Shah", LastName = "Martinez", Gender = "Male", City = "Lahore", IsActive = true }
            };
            return employees;
        }
    }
}
