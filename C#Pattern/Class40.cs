using System;
using System.Collections.Generic;

namespace CollegeManagement
{
	
	class Student
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public List<Course> Courses { get; set; } = new List<Course>();
	}

	// Co
	class Course
	{
		public int Id { get; set; }
		public string Title { get; set; }
	}

	class Program
	{
		static List<Student> students = new List<Student>();
		static List<Course> courses = new List<Course>();
		static int studentIdCounter = 1;
		static int courseIdCounter = 1;

		static void Main(string[] args)
		{
			while (true)
			{

				Console.WriteLine("\n===== College Management System =====");
				Console.WriteLine("1. Add Student");
				Console.WriteLine("2. Add Course");
				Console.WriteLine("3. Enroll Student in Course");
				Console.WriteLine("4. View Students & Enrollments");
				Console.WriteLine("5. Exit");
				Console.Write("Choose an option: ");

				switch (Console.ReadLine())
				{
					case "1":
						AddStudent();
						break;
					case "2":
						AddCourse();
						break;
					case "3":
						EnrollStudent();
						break;
					case "4":
						ViewStudents();
						break;
					case "5":
						return;
					default:
						Console.WriteLine("Invalid option! Try again.");
						break;
				}
			}
		}

		static void AddStudent()
		{
			Console.Write("Enter Student Name: ");
			string name = Console.ReadLine();
			students.Add(new Student { Id = studentIdCounter++, Name = name });
			Console.WriteLine("Student added successfully!");
		}

		static void AddCourse()
		{
			Console.Write("Enter Course Title: ");
			string title = Console.ReadLine();
			courses.Add(new Course { Id = courseIdCounter++, Title = title });
			Console.WriteLine("Course added successfully!");
		}

		static void EnrollStudent()
		{
			if (students.Count == 0 || courses.Count == 0)
			{
				Console.WriteLine("Students or Courses list is empty!");
				return;
			}

			Console.WriteLine("Available Students:");
			foreach (var s in students)
				Console.WriteLine($"{s.Id}. {s.Name}");

			Console.Write("Enter Student Id: ");
			int sid = int.Parse(Console.ReadLine());
			var student = students.Find(s => s.Id == sid);
			if (student == null)
			{
				Console.WriteLine("Student not found!");
				return;
			}

			Console.WriteLine("Available Courses:");
			foreach (var c in courses)
				Console.WriteLine($"{c.Id}. {c.Title}");

			Console.Write("Enter Course Id: ");
			int cid = int.Parse(Console.ReadLine());
			var course = courses.Find(c => c.Id == cid);
			if (course == null)
			{
				Console.WriteLine("Course not found!");
				return;
			}

			student.Courses.Add(course);
			Console.WriteLine("Student enrolled successfully!");
		}

		static void ViewStudents()
		{
			if (students.Count == 0)
			{
				Console.WriteLine("No students available.");
				return;
			}

			foreach (var s in students)
			{
				Console.WriteLine($"ID: {s.Id}, Name: {s.Name}");
				if (s.Courses.Count == 0)
				{
					Console.WriteLine("   No courses enrolled.");
				}
				else
				{
					Console.WriteLine("   Enrolled Courses:");
					foreach (var c in s.Courses)
						Console.WriteLine($"      - {c.Title}");
				}
			}
		}
	}
}
