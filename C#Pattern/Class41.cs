using System;
using System.Collections.Generic;

namespace CollegeManagementSystem
{
	class Student
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int Age { get; set; }
		public string Department { get; set; }
	}




	class Course
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public int Credits { get; set; }
	}

	class Program
	{
		static List<Student> students = new List<Student>();
		static List<Course> courses = new List<Course>();
		static int studentIdCounter = 1;
		static int courseIdCounter = 1;

		static void Main(string[] args)
		{
			bool running = true;


			while (running)
			{
				Console.WriteLine("\n===== College Management Menu =====");
				Console.WriteLine("1. Register Student");
				Console.WriteLine("2. Register Course");
				Console.WriteLine("3. Display All Students");
				Console.WriteLine("4. Display All Courses");
				Console.WriteLine("5. Exit");
				Console.Write("Enter your choice: ");

				switch (Console.ReadLine())
				{
					case "1":
						RegisterStudent();
						break;
					case "2":
						RegisterCourse();
						break;
					case "3":
						DisplayStudents();
						break;
					case "4":
						DisplayCourses();
						break;
					case "5":
						running = false;
						break;
					default:
						Console.WriteLine("Invalid choice! Try again.");
						break;
				}
			}
		}

		static void RegisterStudent()
		{
			Console.Write("Enter Student Name: ");
			string name = Console.ReadLine();

			Console.Write("Enter Age: ");
			int age = int.Parse(Console.ReadLine());

			Console.Write("Enter Department: ");
			string dept = Console.ReadLine();

			students.Add(new Student
			{
				Id = studentIdCounter++,
				Name = name,
				Age = age,
				Department = dept
			});

			Console.WriteLine("Student registered successfully!");
		}

		static void RegisterCourse()
		{
			Console.Write("Enter Course Title: ");
			string title = Console.ReadLine();

			Console.Write("Enter Course Credits: ");
			int credits = int.Parse(Console.ReadLine());

			courses.Add(new Course
			{
				Id = courseIdCounter++,
				Title = title,
				Credits = credits
			});

			Console.WriteLine("Course registered successfully!");
		}

		static void DisplayStudents()
		{
			if (students.Count == 0)
			{
				Console.WriteLine("No students registered yet.");
				return;
			}

			Console.WriteLine("\nRegistered Students:");
			foreach (var s in students)
			{
				Console.WriteLine($"ID: {s.Id}, Name: {s.Name}, Age: {s.Age}, Department: {s.Department}");
			}
		}

		static void DisplayCourses()
		{
			if (courses.Count == 0)
			{
				Console.WriteLine("No courses registered yet.");
				return;
			}

			Console.WriteLine("\nRegistered Courses:");
			foreach (var c in courses)
			{
				Console.WriteLine($"ID: {c.Id}, Title: {c.Title}, Credits: {c.Credits}");
			}
		}
	}
}
