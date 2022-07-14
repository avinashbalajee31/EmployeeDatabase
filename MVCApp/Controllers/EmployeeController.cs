using Microsoft.AspNetCore.Mvc;
using MVCApp.Models;

namespace MVCApp.Controllers
{
    [Route("[controller]")]
    public class EmployeeController : Controller
    {
      
        [Route("Avinash")]
        public IActionResult Index()
        {
            return View();
        }
        
        [Route("GetEmployee")]
        public IActionResult GetEmployee(EmployeeModel input)
        { 
            List<EmployeeModel>emp = getEmployee1(input);
            return View(emp);
        }
        
       

        private List<EmployeeModel> getEmployee1(EmployeeModel input)
        {
            List<EmployeeModel> employeeModels = new List<EmployeeModel>();
            var employee1 = new EmployeeModel();
            employee1.FirstName = "Avinash";
            employee1.LastName = "Balajee";
            employee1.EmpId = 1;
            var employee2 = new EmployeeModel();
            employee2.FirstName = "kurapati";
            employee2.LastName = "sricharan";
            employee2.EmpId = 2;
            var employee3 = new EmployeeModel();
            employee3.FirstName = "iniyan";
            employee3.LastName = "M";
            employee3.EmpId = 3;
            var employee4 = new EmployeeModel();
            employee4.FirstName = "Aravindh";
            employee4.LastName = "S";
            employee4.EmpId = 4;
            var employee5 = new EmployeeModel();
            employee5.FirstName = "Barath";
            employee5.LastName = "Varshan";
            employee5.EmpId = 5;
            employeeModels.Add(employee1);  
            employeeModels.Add(employee2);  
            employeeModels.Add(employee3);  
            employeeModels.Add(employee4);
            employeeModels.Add(employee5);
            if(input != null && input.EmpId>0)
            {
                

                employeeModels.Add(getEmployee2(input));
            }
            return employeeModels;
        }
        private EmployeeModel getEmployee2(EmployeeModel input)
        {
        
            var addedemp = new EmployeeModel();
            addedemp.FirstName = input.FirstName;
            addedemp.LastName = input.LastName;
            addedemp.EmpId = input.EmpId;
            
            return addedemp;
            
        }




    }
}
