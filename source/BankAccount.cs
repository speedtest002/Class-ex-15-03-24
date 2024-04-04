using System;

namespace classLab
{
	internal class BankAccount
	{
		private string password;
		private bool isPasswordVerified;
		private double balance;

		public double Balance
		{
			get 
			{
				if (isPasswordVerified == true)
				{
					return balance;
				}
				else
				{
					return 0;
				}
			}
			set
			{
				if (isPasswordVerified == true)
				{
					balance = value;
				}
                else
                {
					throw new ArgumentException("“Error! Access Denied");
				}
			}
		}
		public static double InterestRate { get; set; }
		public UserInformation UserInf { get; set; }      public BankAccount(string userName, int userAge, uint userID, double Balance, string Password)
		{

			UserInf = new UserInformation(userName, userAge, userID);
			this.password = Password;
			this.balance = Balance;
			isPasswordVerified = false;
		}
		static BankAccount()
		{
			InterestRate = 0.05;
		}
		public double CalculateInterestMoney()
		{
			return Balance * InterestRate;
		}
		public void VerifyPassword(string password)
		{
			if (password == this.password)
				isPasswordVerified = true;
			else 
				isPasswordVerified = false;
		}
	}
}
