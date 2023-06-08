using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace profZawadzkiLesson1
{
	public class Employee : Person
	{
		int _employeeId;
		string _departmentName;
		public int employeeID { get => _employeeId; set => _employeeId = value; }
		public string Department { get => _departmentName; set => _departmentName = value; }
		public Employee(string name, string lastName, int employeeId, string department)
		{
			this.Name = name;
			this.LastName = lastName;
			this._employeeId = employeeId;
			_departmentName = department;
		}
		public override string ToString()
		{
			return $"{Name} {LastName} {_employeeId} {_departmentName}";
		}
	}
}
