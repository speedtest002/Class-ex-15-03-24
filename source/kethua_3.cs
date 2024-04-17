using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classLab
{
   partial class Program
   {
      public static void Lab3_1()
      {
         UserInformation[] users = new UserInformation[6]
         {
            new Employee("Employee 0", 23, 1000, 10_000_000),
            new Employee("Employee 1", 21, 1001, 11_000_000),
            new Manager ("Manager 2", 27, 1012, 12_000_000),
            new Manager ("Manager 3", 24, 1013, 18_000_000),
            new Director("Director 4", 32, 1024, 13_000_000),
            new Director("Director 5", 29, 1025, 14_000_000),
         };
         foreach (var user in users)
         {
            Console.WriteLine($"{user.UserName}: {user.GetSalary()}\n");
         }
         Console.WriteLine("_______ HIGH TO LOW _________");
         for (int i = 0; i < 6; i++)
         {
            for (int j = 0; j < 6 - i - 1; j++)
            {
               if (users[j].GetSalary() < users[j + 1].GetSalary())
               {
                  var temp = users[j];
                  users[j] = users[j + 1];
                  users[j + 1] = temp;
               }
            }
         }
         foreach (var user in users)
         {
            Console.WriteLine($"{user.UserName}: {user.GetSalary()}\n");
         }

         Console.WriteLine("_______ LOW TO HIGH _________");
         for (int i = 0; i < 6; i++)
         {
            for (int j = 0; j < 6 - i - 1; j++)
            {
               if (users[j].GetSalary() > users[j + 1].GetSalary())
               {
                  var temp = users[j];
                  users[j] = users[j + 1];
                  users[j + 1] = temp;
               }
            }
         }
         foreach (var user in users)
         {
            Console.WriteLine($"{user.UserName}: {user.GetSalary()}\n");
         }
      }
   
      public static void Lab3_2()
      {
         BankAccount alexAccount = null;
         GetUserBankAccountInformation(out alexAccount);
         Console.WriteLine("Please type in your password to show current balance");
         alexAccount.VerifyPassword(Console.ReadLine());
         Console.WriteLine($"{alexAccount.CalculateInterestMoney()}");
         Console.WriteLine($"interest rate: {BankAccount.InterestRate}");
         Console.ReadLine();      }
      public static void GetUserBankAccountInformation(out BankAccount account)
      {
         Console.WriteLine("Please type in your name");
         string userName = Console.ReadLine();
         Console.WriteLine("Please type in your age");
         int userAge = int.Parse(Console.ReadLine());
         Console.WriteLine("Please type in your ID");
         uint userID = uint.Parse(Console.ReadLine());
         Console.WriteLine("Please type in your balance");
         double balance = double.Parse(Console.ReadLine());
         Console.WriteLine("Please type in your password");
         string password = Console.ReadLine();
         account = new BankAccount(userName, userAge, userID, balance, password);
         //var account = new BankAccount(string userName, int userAge, uint userID, double Balance, string Password);
      }
   }
   //public static void bai1_3() //
   //{
   //var creditCard = new CreditCard("Gold", "Peter", 1000, "12/2025"); 
   //var debitCard = new DebitCard("Andy", 2000, "62/2025");
   //creditCard.CalculateAnnualFee();
   //debitCard.CalculateAnnualFee();
   //System.Console.WriteLine(debitCard.ToString());
   //System.Console.WriteLine(creditCard.ToString());
   //Console.WriteLine("------------------------------------------------");
   //var bankCards = new BankCard[5];
   //bankCards[0] = new CreditCard("Broze", "James", 1, "2020");
   //bankCards[1] = new CreditCard("Gold", "Andy", 2, "2021");
   //bankCards[2] = new CreditCard("Diamond", "Bill", 3, "2022");
   //bankCards[3] = new DebitCard("Carol", 4, "2023");
   //bankCards[4] = new DebitCard("Evelyn", 5, "2024");
   ////Console.WriteLine();
   //foreach (BankCard bc in bankCards)
   //{
   //   bc.CalculateAnnualFee();
   //   System.Console.WriteLine(bc.ToString());
   //}
   //}

   class BankCard
   {
      protected int annualFee;
      private string name;
      private int cardID;
      private string expirationDate;

      public BankCard()
      {
         System.Console.WriteLine("Parent contructor with no parameter");
      }
      public BankCard(string name, int cardID, string expirationDate)
      {
         System.Console.WriteLine("Parent Constructor with 3 parameters");
         this.name = name;
         this.cardID = cardID;
         this.expirationDate = expirationDate;
      }
      public override string ToString()
      {
         return $"Name: {name}; Card ID: {cardID}; Expiaration date: {expirationDate};annual fee: {annualFee}";
      }
      public virtual void CalculateAnnualFee()
      {
         annualFee = 0;
      }
   }
   class CreditCard : BankCard
   {
      public CreditCard()
      {
         System.Console.WriteLine("Child constructor with no parameter");
      }
      public CreditCard(string rank, string name, int cardID, string expirationDate) : base(name, cardID, expirationDate)
      {
         System.Console.WriteLine("Child Constructor with 4 parameters");
         System.Console.WriteLine($"Rank: {rank}");
      }
      public void CalculateAnnualFee()
      {
         annualFee = 50 + 2 * 12;
      }
   }
   class DebitCard : BankCard
   {
      public DebitCard(string name, int cardID, string expirationDate) : base(name, cardID, expirationDate)
      {
         System.Console.WriteLine("Child Constructor with 3 parameters");
      }
      public void CalculateAnnualFee()
      {
         annualFee = 100;
      }
   }
}
