using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace profZawadzkiLesson1
{
	public class Employee : Person
	{

		int employeeID;
		string department;

		public int EmployeeID { get => employeeID; set => employeeID = value; }
		public string Department { get => department; set => department = value; }

		public Employee(string name, string lastName, int employeeID, string department)
		{
			this.name = name;
			this.lastName = lastName;
			this.employeeID = employeeID;
			this.department = department;
		}
		public override string ToString()
		{
			return $"{Name} {LastName} {employeeID} {department}";
		}
	}
}
