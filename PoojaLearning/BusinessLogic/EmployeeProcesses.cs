using PoojaLearning.DataAccess;
using PoojaLearning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PoojaLearning.BusinessLogic
{
    public class EmployeeProcesses
    {
        EmployeeDataAccess empDA = new EmployeeDataAccess();


        public void UpsertEmployeee(Employee emp)
        {
            empDA.UpsertEmployee(emp);
        }
        public Employee GetEmployee(int empId)
        {
            return empDA.GetEmployee(empId);
        }

        public Employee GetEmployeeByName(String empName)
        {
            return empDA.GetEmployeeByName(empName);
        }
    }
}