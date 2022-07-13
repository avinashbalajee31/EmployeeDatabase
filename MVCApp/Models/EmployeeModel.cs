using System.ComponentModel.DataAnnotations;

namespace MVCApp.Models
{
    public class EmployeeModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int EmpId { get; set; }
    }
}
