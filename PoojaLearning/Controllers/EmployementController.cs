using PoojaLearning.BusinessLogic;
using PoojaLearning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace PoojaLearning.Controllers
{
    public class EmployementController : ApiController
    {
        EmployeeProcesses empProcess = new EmployeeProcesses();
        [HttpPost]
        [Route("emp/details/new")]
        public void SubmitEmployeeDetails(Employee employee)
        {
            empProcess.UpsertEmployeee(employee);
        }

        [HttpGet]
        [Route("emp/details")]
        public Employee GetEmployeeDetails(int empId)
        {
            return empProcess.GetEmployee(empId);
        }

        [HttpGet]
        [Route("empName/details")]
        public Employee GetEmployeeDetailsByName(string empName)
        {
            return empProcess.GetEmployeeByName(empName);
        }

    }
}