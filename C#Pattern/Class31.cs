using System;

public class BankAccount
{
	// Private field - not accessible directly from outside
	private double balance;

	// Public property - controls access to the private field
	public double Balance
	{
		get { return balance; }
		private set { balance = value; } // Only internal updates allowed
	}
	public BankAccount(double initialBalance)
	{
		Balance = initialBalance;
	}

	// Public method to deposit money
	public void Deposit(double amount)
	{
		if (amount > 0)
		{
			Balance += amount;
			Console.WriteLine($"Deposited ₹{amount}. New balance: ₹{Balance}");
		}
		else
		{
			Console.WriteLine("Deposit amount must be positive.");
		}
	}

	// Public method to withdraw money
	public void Withdraw(double amount)
	{
		if (amount > 0 && amount <= Balance)
		{
			Balance -= amount;
			Console.WriteLine($"Withdrew ₹{amount}. New balance: ₹{Balance}");
		}
		else
		{
			Console.WriteLine("Invalid withdrawal amount.");
		}
	}
}

