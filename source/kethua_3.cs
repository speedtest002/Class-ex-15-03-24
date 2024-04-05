using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classLab
{
   partial class Program
   {
      public static void bai1_3() //
      {
         var creditCard = new CreditCard("Gold", "Peter", 1000, "12/2025"); 
         var debitCard = new DebitCard("Andy", 2000, "62/2025");
         creditCard.CalculateAnnualFee();
         debitCard.CalculateAnnualFee();
         System.Console.WriteLine(debitCard.ToString());
         System.Console.WriteLine(creditCard.ToString());
         Console.WriteLine("------------------------------------------------");
         BankCard[] bankCards = new BankCard[5];
         bankCards[0] = new CreditCard("Silver", "James", 1, "2020");
         bankCards[1] = new CreditCard("Gold", "Andy", 2, "2021");
         bankCards[2] = new CreditCard("Diamond", "Bill", 3, "2022");
         bankCards[3] = new DebitCard("Carol", 4, "2023");
         bankCards[4] = new DebitCard("Evelyn", 5, "2024");

         foreach (BankCard bc in bankCards)
         {
            bc.CalculateAnnualFee();
            System.Console.WriteLine(bc.ToString());
         }
      }
   }
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
   class CreditCard:BankCard
   {
      public CreditCard()
      {
         System.Console.WriteLine("Child constructor with no parameter");
      }
      public CreditCard(string rank, string name, int cardID, string expirationDate):base(name, cardID, expirationDate)
      {
         System.Console.WriteLine("Child Constructor with 4 parameters");
         System.Console.WriteLine($"Rank: {rank}");
      }
      public override void CalculateAnnualFee()
      {
         annualFee = 50 + 2 * 12;
      }
   }

   class DebitCard:BankCard
   {
      public DebitCard(string name, int cardID, string expirationDate) : base(name, cardID, expirationDate)
      {
         System.Console.WriteLine("Child Constructor with 3 parameters");
      }
      public override void CalculateAnnualFee()
      {
         annualFee = 100;
      }
   }
}
