using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using testCS;

namespace newTest
{
	class Program
	{
		public static void Main()
		{
			//To do
			try
			{
				Point a = new Point(0, 0);
				Point b = new Point(1366, 768);
				Point c = new Point(300, 400);
				double AB = a.DistanceTo(b);
				double BC = b.DistanceTo(c);
				Console.WriteLine($"Khoang cach AB la {AB} va khoang cach BC la {BC}");
				Console.WriteLine($"So luong point la: {Point.objectCount}");
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}


			//BT
			//#bai 1
			//UserInformation user = new UserInformation();
			//user.GetUserInformation();
			//user.PrintUserInformation();

			//#bai 2
			//UserInformation user1 = new UserInformation("User 1", 18, 001);
			//UserInformation user2 = new UserInformation("User 2", 17, 002);
			//UserInformation user3 = new UserInformation("User 3", 15, 003);
			//
			//List<UserInformation> users = new List<UserInformation>() { user1, user2, user3 };
			//
			//Console.WriteLine("List user sorted by Age:");
			//List<UserInformation> sortedUsersByAge = users.OrderBy(x => x.userAge).ToList();
			//Console.WriteLine(String.Join(Environment.NewLine, sortedUsersByAge));
			//
			//Console.WriteLine("\n\nList user sorted by ID:");
			//List<UserInformation> sortedUsersByID = users.OrderByDescending(x => x.userID).ToList();
			//Console.WriteLine(String.Join(Environment.NewLine, sortedUsersByID));

			Console.ReadLine();
		}
	}
}