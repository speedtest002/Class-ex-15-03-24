using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using testCS;

namespace newTest
{
	partial class Program
	{
		public static void Main()
		{
			try
			{
				//Bai1();
				//Bai2();
				//Bai1_2();

			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			Console.ReadLine();
		}
		public static void YourCode() //
		{
			// Make an account.
			SavingsAccount s1 = new SavingsAccount(50);
			// Print the current interest rate.
			Console.WriteLine("Interest Rate is: {0}", SavingsAccount.currInterestRate);
			// Change the interest rate
			SavingsAccount.currInterestRate = 0.08;
			// Make a second account.
			SavingsAccount s2 = new SavingsAccount(100);
			// Should print 0.08...right??
			Console.WriteLine("Interest Rate is: {0}", SavingsAccount.currInterestRate);

		}
	}
	class SavingsAccount
	{
		// Instance-level data.
		public double currBalance;
		// A static point of data.
		public static double currInterestRate = 0.04;
		public SavingsAccount(double balance)
		{
			// This is static data! -> potential error
			currInterestRate = 0.04;
			currBalance = balance;
		}
		public double GetInterestRate()
		{ 
			return currInterestRate;
		}

	}
}