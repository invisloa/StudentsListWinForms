using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace profZawadzkiLesson1
{
	public class StudentsListGenerator
	{
		List<Student> students = new List<Student>();
		Random random = new Random();

		// List of names and last names
		string[] names = { "Alice", "Bob", "Charlie", "David", "Eve", "Frank", "Grace", "Heidi", "Ivan", "Judy" };
		string[] lastNames = { "Anderson", "Baker", "Carter", "Davis", "Edwards", "Fisher", "Garcia", "Harris", "Irwin", "Johnson" };

        // Generate 20 random students
		public List<Student> MakeStudentsList()
		{
			for (int i = 1; i <= 20; i++)
			{
				// Randomly select a name and last name
				string name = names[random.Next(names.Length)];
				string lastName = lastNames[random.Next(lastNames.Length)];
				// Create a student with a random ID
				int studentId = random.Next(10000, 99999);
				Student student = new Student(name, lastName, studentId);
				// Add the student to the list
				students.Add(student);
			}
			return students;
		}
	}
}
