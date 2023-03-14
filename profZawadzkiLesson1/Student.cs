using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace profZawadzkiLesson1
{
	public class Student
	{
		string name;
		string lastName;
		int studentId;

		public string Name { get => name; set => name = value; }
		public string LastName { get => lastName; set => lastName = value; }
		public int StudentId { get => studentId; set => studentId = value; }

		public Student(string name, string lastName, int studentId)
		{
			this.name = name;
			this.lastName = lastName;
			this.studentId = studentId;
		}
		public override string ToString()
		{
			return $"{Name} {LastName} {studentId}";
		}
	}
}
