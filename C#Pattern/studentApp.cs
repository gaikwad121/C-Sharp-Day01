using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeManagemnetStudentApplication
{
	internal class StudentApp
	{
		private string name;
		private int age;
		private string studentId;
		List<string> courses;

		public StudentApp(string name, int age, string studentId)
		{
			this.name = name;
			this.age = age;
			this.studentId = studentId;
			courses = new List<string>();
		}
		public void StudentInfo()
		{
			Console.WriteLine("student name : " + name);
			Console.WriteLine("student age : " + age);
			Console.WriteLine("student studentId : " + studentId);

		}
		public void EnrollCourse(string course)
		{
			if (validateCourse(course))
				if (!courses.Contains(course))
				{
					courses.Add(course);
					Console.WriteLine("Course enrolled sucessfully.");
				}
				else
				{
					Console.WriteLine("alread enrolled course.");

				}
		}
		public bool validateCourse(string course)
		{
			if (course.Equals("Java") || course.Equals("C#)"))
			{
				return true;
			}
			else
			{
				Console.Error.WriteLine("Invalid course");
				return false;

			}
		}
	}
}
