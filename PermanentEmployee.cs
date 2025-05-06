using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    internal class PermanentEmployee : Employee
    {
        // Property of Employee joining date
        public DateTime JoiningDate { get; set; }
        // Property of Employee insurance detail
        public bool HasInsuranceCoverage { get; set; }
        // Property of Employee Leave encashment balance
        public int LeaveEncashmentBalance { get; set; }

        // print the permanenet employee detail
        public override void Display()
        {
            Console.WriteLine("Permanent Employee : ");
            base.Display();
            string insurance = HasInsuranceCoverage ? "Insurance Coverage is Done" : "No Any Insurance Coverage";
            Console.WriteLine($"Joining Date - {JoiningDate}\t{insurance}\tBalance Leave Encashment - {LeaveEncashmentBalance}");
        }
    }
}
