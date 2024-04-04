using System;

namespace classLab
{
	partial class Program
	{
		public static void Bai1_2()
		{
			UserInformation user1 = new UserInformation("User 1", 28, 1001);
			Console.WriteLine($"{user1}");
			UserInformation user2 = new UserInformation("User 2", 24, 2002);
			Console.WriteLine($"{user2}");
			UserInformation user3 = new UserInformation("User 3", 43, 003);
			Console.WriteLine($"{user3}");
		}
		public static void Bai2_2() 
		{
			BankAccount alexAccount = new BankAccount("alex", 20, 1111, 1000, "alex123");
			//Nhap dung password
			Console.WriteLine("Please enter your password");
			alexAccount.VerifyPassword(Console.ReadLine());
			Console.WriteLine(alexAccount.CalculateInterestMoney());
			//Nhap sai password
			Console.WriteLine("Please enter your password");
			alexAccount.VerifyPassword(Console.ReadLine());
			Console.WriteLine(alexAccount.CalculateInterestMoney());
		}
	}
}