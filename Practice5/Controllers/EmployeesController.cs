using BasicAuth.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BasicAuth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        [Authorize]
        public List<Employee> GetEmployees() 
        {
            return Employee.GetEmployees();
        }
    }
}
