using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    internal class ContractEmployee : Employee
    {
        // Property of Employee Contract month
        public int ContractDurationMonths { get; set; }
        // Property of Employee remote or not
        public bool IsRemote { get; set; }

        // display the Contract employee detail
        public override void Display()
        {
            Console.WriteLine("Contract Employee : ");
            base.Display();
            string remoteStatus = IsRemote ? "a" : "Not a";
            Console.WriteLine($"Contract Duration Months - {ContractDurationMonths}\tContract is {remoteStatus} Remote");
        }
    }
}
