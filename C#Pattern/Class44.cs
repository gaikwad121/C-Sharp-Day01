using System;
using System.Collections.Generic;

namespace DressShopManagement
{
	class Dress
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Size { get; set; }
		public double Price { get; set; }
		public int Stock { get; set; }
	}

	class Program
	{
		static List<Dress> dresses = new List<Dress>();
		static int dressIdCounter = 1;
		static double totalRevenue = 0;

		static void Main(string[] args)
		{
			bool running = true;
			while (running)
			{
				Console.WriteLine("\n===== Dress Shop Management =====");
				Console.WriteLine("1. Add Dress");
				Console.WriteLine("2. View All Dresses");
				Console.WriteLine("3. Sell Dress");
				Console.WriteLine("4. Search Dress by Name");
				Console.WriteLine("5. View Sales Report");
				Console.WriteLine("6. Exit");
				Console.Write("Enter your choice: ");

				switch (Console.ReadLine())
				{
					case "1":
						AddDress();
						break;
					case "2":
						ViewDresses();
						break;
					case "3":
						SellDress();
						break;
					case "4":
						SearchDress();
						break;
					case "5":
						ViewSalesReport();
						break;
					case "6":
						running = false;
						break;
					default:
						Console.WriteLine("Invalid choice! Try again.");
						break;
				}
			}
		}

		static void AddDress()
		{
			Console.Write("Enter Dress Name: ");
			string name = Console.ReadLine();

			Console.Write("Enter Size (S/M/L/XL): ");
			string size = Console.ReadLine();

			Console.Write("Enter Price: ");
			double price = double.Parse(Console.ReadLine());

			Console.Write("Enter Stock Quantity: ");
			int stock = int.Parse(Console.ReadLine());

			dresses.Add(new Dress
			{
				Id = dressIdCounter++,
				Name = name,
				Size = size,
				Price = price,
				Stock = stock
			});

			Console.WriteLine("Dress added successfully!");
		}

		static void ViewDresses()
		{
			if (dresses.Count == 0)
			{
				Console.WriteLine("No dresses available.");
				return;
			}

			Console.WriteLine("\nAvailable Dresses:");
			foreach (var d in dresses)
			{
				Console.WriteLine($"ID: {d.Id}, Name: {d.Name}, Size: {d.Size}, Price: ${d.Price}, Stock: {d.Stock}");
			}
		}

		static void SellDress()
		{
			Console.Write("Enter Dress ID to sell: ");
			int id = int.Parse(Console.ReadLine());

			var dress = dresses.Find(d => d.Id == id);
			if (dress == null)
			{
				Console.WriteLine("Dress not found!");
				return;
			}

			if (dress.Stock > 0)
			{
				dress.Stock--;
				totalRevenue += dress.Price;
				Console.WriteLine($"Dress '{dress.Name}' sold! Remaining stock: {dress.Stock}");
			}
			else
			{
				Console.WriteLine("Out of stock!");
			}
		}

		static void SearchDress()
		{
			Console.Write("Enter Dress Name to search: ");
			string name = Console.ReadLine().ToLower();

			var results = dresses.FindAll(d => d.Name.ToLower().Contains(name));
			if (results.Count == 0)
			{
				Console.WriteLine("No dresses found.");
				return;
			}

			Console.WriteLine("\nSearch Results:");
			foreach (var d in results)
			{
				Console.WriteLine($"ID: {d.Id}, Name: {d.Name}, Size: {d.Size}, Price: ${d.Price}, Stock: {d.Stock}");
			}
		}

		static void ViewSalesReport()
		{
			Console.WriteLine($"\nTotal Revenue: ${totalRevenue}");
		}
	}
}
