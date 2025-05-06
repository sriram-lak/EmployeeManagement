using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    internal class Employee
    {
        // Property of Employee id
        public int EmployeeId { get;set;}
        // Property of employee name
        public string Name { get;set;}
        // Property of employee department
        public string Department { get;set;}
        // Property of employee Salary
        public double Salary { get;set;}

        // Print the all employee detail
        public virtual void Display()
        {
            Console.WriteLine($"EmployeeId - {EmployeeId}\tName - {Name}\tDepartment - {Department}\t Salary - Rs.{Salary}\t");
        }
    }
}
