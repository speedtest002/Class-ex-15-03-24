using System;

namespace Lab6
{
   public class UserInformation
   {
      private string userName;
      private uint userAge;
      private uint userID;
      public string UserName
      {
         get { return userName; }
         set
         {
            userName = value;
         }
      }
      public uint UserAge
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
               throw new Exception("Error! User’s age must be larger than 18");
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
               throw new Exception("Error! ID must be between 1000 and 9999");
            }
         }
      }
      public UserInformation()
      { }
      public UserInformation(string name, uint age, uint id)
      {
         UserName = name;
         UserAge = age;
         UserID = id;
      }
      public string OneLineInformation
      {
         get { return $"Username: {UserName}, user ID{UserID}, user age{UserAge}"; }
      }
   }
}
