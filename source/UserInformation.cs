using System;

namespace classLab
{
   internal class UserInformation
   {
      private string userName;
      private int userAge;
      private uint userID;

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
               throw new ArgumentException("Error!\r\nUser’s age must be larger than 18.");
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
               throw new ArgumentException("Error! ID must be between 1000 and 9999.");
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
         //return "[" + userName + "," + userAge + "," + userID + "]";
         return String.Format($"[{userName}, {userAge}, {userID}]");
      }
   }
}
