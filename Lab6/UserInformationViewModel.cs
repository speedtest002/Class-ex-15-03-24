namespace Lab6
{
   public class UserInformationViewModel
   {
      private UserInformation defaultUser = new UserInformation(name: "ABC", age: 19, id: 1001);//Khởi tạo đối tượng mặc định
      public UserInformation DefaultUser //Tạo property DefaultUser
      {
         get { return this.defaultUser; }
         set { this.defaultUser = value; }
      }

      public void SetDefaultUser(string name, uint age, uint id)
      {
         defaultUser = new UserInformation(name, age, id);
      }
   }
}
