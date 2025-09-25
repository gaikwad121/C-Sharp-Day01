using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeManagemnetStudentApplication
{
	public class StudentApp
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
			if (!validateCourse(course))
			{
				Console.WriteLine("Invalid course.");
				return;
			}

			if (courses.Contains(course))
			{
				Console.WriteLine("Already enrolled in this course.");
				return;
			}

			courses.Add(course);
			Console.WriteLine("Course enrolled successfully.");
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
