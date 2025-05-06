# EmployeeManagement
C# Console Application Exercise – Employee Management System
Objective:
Create a console-based application in C# to manage employees using basic OOP concepts like inheritance, and practice user input, loops, conditional statements, and lists.
Requirements:
1.	Create a Base Class – Employee
Properties:
•	int EmployeeId
•	string Name
•	string Department
•	double Salary
2.	Create an Inherited Class – PermanentEmployee
Additional Properties:
•	DateTime JoiningDate – when the employee joined
•	bool HasInsuranceCoverage – whether insurance is provided
•	int LeaveEncashmentBalance – number of paid leaves that can be encashed
3.	Create another Inherited Class – ContractEmployee
Additional Properties:
•	int ContractDurationMonths – duration of the contract
•	bool IsRemote – whether the employee works remotely
4.	Preload a few employee records (maximum of two PermanentEmployee and two ContractEmployee) when the application starts.

5.	Display a Menu with the following options:
1. Create a New Permanent Employee
2. Create a New Contract Employee
3. Delete an Employee
4. Exit
Based on user input:
•	Get all required details via console for creating a new employee.
•	Add the new employee to the existing list. 
•	For deletion, ask for the Employee ID and remove the matching employee.
6.	After each operation (except Exit), display the list of all employees with all relevant details.

