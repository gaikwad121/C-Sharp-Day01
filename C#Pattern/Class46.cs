using System;

namespace EncapsulationExample
{
	class Dress
	{
		// Private fields (hidden from outside)
		private string name;
		private double price;
		private int stock;

		// Public property for Name
		public string Name
		{
			get { return name; }
			set
			{
				if (string.IsNullOrWhiteSpace(value))
					Console.WriteLine("Name cannot be empty.");
				else
					name = value;
			}
		}

		// Public property for Price
		public double Price
		{
			get { return price; }
			set
			{
				if (value <= 0)
					Console.WriteLine("Price must be positive.");
				else
					price = value;
			}
		}

		// Public property for Stock
		public int Stock
		{
			get { return stock; }
			set
			{
				if (value < 0)
					Console.WriteLine("Stock cannot be negative.");
				else
					stock = value;
			}
		}

		// Method to display dress details
		public void ShowDetails()
		{
			Console.WriteLine($"Dress: {Name}, Price: {Price}, Stock: {Stock}");
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Dress d1 = new Dress();

			d1.Name = "Evening Gown";
			d1.Price = 120.50;
			d1.Stock = 10;

			d1.ShowDetails();

			// Trying invalid values
			d1.Price = -50;   // Error message
			d1.Stock = -2;    // Error message
		}
	}
}
