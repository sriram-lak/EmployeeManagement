using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    internal class EmployeeOperation
    {
        static private List<Employee> employees = new List<Employee>();

        static private List<String> department = new List<String> {
            "Software Developer","Software Trainee", "Senior Software Developer","System Administator","Supply Chain","Finance","HR"
        };
        public void Start()
        {
            // declare the default permanent employee
            InitilizeRecordAddedPermanentEmployee();
            // declare the default contract employee
            InitilizeRecordAddedContractEmployee();
            bool isContinue = true;
            while (isContinue)
            {
                Console.WriteLine("Press 1 : Create a New Permanent Employee\nPress 2 : Create a New Contract Employee\nPress 3 : Delete an Employee\nPress 4 : Exit\n");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        CreatePermanentEmployee();
                        break;
                    case "2":
                        CreateContractEmployee();
                        break;
                    case "3":
                        DeleteEmployee();
                        break;
                    case "4":
                        isContinue = false;
                        return;
                    default:
                        Console.WriteLine("Please Choose the above Key ");
                        break;
                }
                DisplayEmployee();
            }
        }
        // Initilized Two Permanent Employee 
        public static void InitilizeRecordAddedPermanentEmployee()
        {
            employees.Add(new PermanentEmployee
            {
                EmployeeId = 1,
                Name = "Sriram",
                Department = department[0],
                Salary = 100000,
                JoiningDate = new DateTime(2014, 4, 21),
                HasInsuranceCoverage = true,
                LeaveEncashmentBalance = 10
            });
            employees.Add(new PermanentEmployee
            {
                EmployeeId = 2,
                Name = "Lakshmanan",
                Department = department[2],
                Salary = 150000,
                JoiningDate = new DateTime(2011, 1, 1),
                HasInsuranceCoverage = true,
                LeaveEncashmentBalance = 10
            });
        }
        //Initilized Two Contract Employee
        public static void InitilizeRecordAddedContractEmployee()
        {
            employees.Add(new ContractEmployee {
                EmployeeId = 3,
                Name = "Suman",
                Department = department[1],
                Salary = 30000,
                ContractDurationMonths = 6,
                IsRemote = false
            });
            employees.Add(new ContractEmployee
            {
                EmployeeId = 4,
                Name = "Kumar",
                Department = department[5],
                Salary = 25000,
                ContractDurationMonths = 12,
                IsRemote = false
            });
        }
        // Create the new Permanent Employees
        public static void CreatePermanentEmployee()
        {
            PermanentEmployee employee = new PermanentEmployee();
            employee.EmployeeId = GetEmployeeId();
            Console.WriteLine("Enter the Employee Name");
            employee.Name = Console.ReadLine();
            employee.Department = CheckDepartment();
            employee.Salary = CheckSalary();
            employee.JoiningDate = CheckDate();
            employee.HasInsuranceCoverage = SelectInsuranceCoverage();
            employee.LeaveEncashmentBalance = CheckLeave();
            employees.Add(employee);
        }
        // Create the new Contract Employees
        public static void CreateContractEmployee()
        {
            ContractEmployee employee = new ContractEmployee();
            employee.EmployeeId = GetEmployeeId();
            Console.WriteLine("Enter the Employee Name");
            employee.Name = Console.ReadLine();
            employee.Department = CheckDepartment();
            employee.Salary = CheckSalary();
            employee.ContractDurationMonths = CheckMonths();
            employee.IsRemote = SelectIsRemote();
            employees.Add(employee);
        }
        // Delete the Employee detail
        public static void DeleteEmployee()
        {
            Console.WriteLine("Please Enter the Employee Id to Remove the employee");
            int employeeId;
            while (true) {
                if (int.TryParse(Console.ReadLine(), out employeeId))
                {
                    try
                    {
                        Employee emp = employees.FirstOrDefault(e => e.EmployeeId == employeeId);
                        if (emp != null)
                        {
                            employees.Remove(emp);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Employee Id Not Found");
                            break;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error : " + e.GetType().Name);
                    }
                }
                else
                {
                    Console.WriteLine("Please enter the integer format");
                }
            }
        }
        // Employees get Function
        public static int GetEmployeeId()
        {
            int employeesId = employees.Count == 0 ? 1 : employees.Max(x => x.EmployeeId) + 1;
            return employeesId;
        }
        // Check the Employee department
        public static string CheckDepartment()
        {
            while (true)
            {
                Console.WriteLine("Enter the Below Employee Department");
                try
                {
                    foreach (String domain in department)
                    {
                        Console.Write(domain + " ");
                    }
                }
                catch (Exception e) { Console.WriteLine("Error : " + e.GetType().Name); }
                Console.WriteLine();
                string departmentEmployee = Console.ReadLine();
                if (department.Contains(departmentEmployee))
                {
                    return departmentEmployee;
                }
                Console.WriteLine("Please enter the correct department");
            }
        }
        // Salary Check function
        public static double CheckSalary()
        {
            double salary;
            while (true)
            {
                Console.WriteLine("Enter the Salary of Employee");
                if(double.TryParse(Console.ReadLine(), out salary) && salary > 0)
                {
                    return salary;
                }
                Console.WriteLine("Please Enter the Valid Salary Amount");
            }
        }
        // Check the Joining date
        public static DateTime CheckDate() {
            DateTime date;
            while (true) {
                Console.WriteLine("\"Enter Joining Date (yyyy-mm-dd): \"");
                if(DateTime.TryParse(Console.ReadLine(),out date))
                {
                    return date;
                }
                Console.WriteLine("Please Enter the Valid Date");
            }
        }
        // Check the Insurance
        public static bool SelectInsuranceCoverage()
        {
            bool result;
            while (true)
            {
                Console.WriteLine("Has Insurance Coverage (yes/no): ");
                string input = Console.ReadLine().ToLower();
                if (input == "yes") return true;
                else if (input == "no") return false;
                Console.WriteLine("Please the Enter \"Yes\" or \"No\"");
            }
        }
        // check the Leave 
        public static int CheckLeave()
        {
            int leave;
            while (true)
            {
                Console.WriteLine("Enter the Leave Encashment Balance");
                if(int.TryParse(Console.ReadLine(),out leave) && leave >= 0)
                {
                    return leave;
                }
                Console.WriteLine("Please Enter the Valid Format");
            }
        }
        // Check the number of month contract
        public static int CheckMonths()
        {
            int month;
            while (true)
            {
                Console.WriteLine("Enter the Contract Months");
                if (int.TryParse(Console.ReadLine(), out month) && month > 0)
                {
                    return month;
                }
                Console.WriteLine("Please Enter the Valid Format");
            }
        }
        // Check the work is remote or not
        public static bool SelectIsRemote()
        {
            bool result;
            while (true)
            {
                Console.WriteLine("Is Remote (yes/no): ");
                string input = Console.ReadLine().ToLower();
                if (input == "yes") return true;
                else if (input == "no") return false;
                Console.WriteLine("Please the Enter \"Yes\" or \"No\"");
            }
        }
        // Display the Employee Detail
        public void DisplayEmployee()
        {
            if(employees.Count == 0)
            {
                Console.WriteLine("No Employees are found");
            }
            else
            {
                foreach(Employee e in employees)
                {
                    e.Display();
                }
            }
        }
    }
}
