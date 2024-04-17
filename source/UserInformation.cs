using System;

namespace classLab
{
   internal class UserInformation
   {
      private string userName;
      private int userAge;
      private uint userID;
      private double baseSalary;

      public string UserName
      {
         get { return userName; }
         set
         {
            userName = value;
         }
      }
      public int UserAge
      {
         get { return userAge; }
         set
         {
            if (value > 18)
            {
               userAge = value;
            }
            else
            {
               throw new OverflowException();
               //throw new UserAccountException();
            }
         }
      }
      public uint UserID
      {
         get { return userID; }
         set
         {
            if (!(value < 1000 || value > 9999))
            {
               userID = value;
            }
            else
            {
               throw new OverflowException();
               //throw new UserAccountException();
            }
         }
      }
      public UserInformation()
      { }
      public UserInformation(string name, int age, uint id)
      {
         UserName = name;
         UserAge = age;
         UserID = id;
      }
      public override string ToString()
      {
         return String.Format($"[{userName}, {userAge}, {userID}]");
      }
      //lab3
      public double BaseSalary
      {
         get { return baseSalary; }
         set { baseSalary = value; }
      }
      public UserInformation(string name, int age, uint id, double baseSalary) : this(name, age, id)
      {
         BaseSalary = baseSalary;
      }
      public virtual double GetSalary()
      {
         return BaseSalary;
      }
   }
}
