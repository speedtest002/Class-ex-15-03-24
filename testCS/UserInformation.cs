using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testCS
{
	internal class UserInformation
	{
		public string userName;
		public int userAge;
		public uint userID;

		public void GetUserInformation()
		{
			string userAgeInput;
			string userIDInput;
			//User name input
			Console.Write("Please input User Name: ");
			userName = Console.ReadLine();
			//User Age Input
			Console.Write("Please input Age for {0}: ", userName);
			userAgeInput = Console.ReadLine();
			while (!int.TryParse(userAgeInput, out userAge))
			{
				Console.WriteLine("Invalid Age input. Please enter a valid integer.");
				Console.Write("Please input Age for {0}: ", userName);
				userAgeInput = Console.ReadLine();
			}
			//User ID Input
			Console.Write("Please input ID for {0}: ", userName);
			userIDInput = Console.ReadLine();
			while (!uint.TryParse(userIDInput, out userID))
			{
				Console.WriteLine("Invalid ID input. Please enter a valid unsigned integer.");
				Console.Write("Please input ID for {0}: ", userName);
				userIDInput = Console.ReadLine();
			}
		}
		public void PrintUserInformation()
		{
			Console.Write($"User Name:\t{userName}\nAge:\t\t{userAge}\nID:\t\t{userID}");
		}

		public UserInformation()
		{ }
		public UserInformation(string userName, int userAge, uint userID)
		{
			this.userName = userName;
			this.userAge = userAge;
			this.userID = userID;
		}
		public override string ToString()
		{
			//return "[" + userName + "," + userAge + "," + userID + "]";
			return String.Format($"[{userName}, {userAge}, {userID}]");
		}
	}						    
}							   
