using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Navigation_View
{
   /// <summary>
   /// An empty page that can be used on its own or navigated to within a Frame.
   /// </summary>
   public sealed partial class AddFriendPage : Page
   {
      public AddFriendPage()
      {
         this.InitializeComponent();
      }

      private void AddButton_Click(object sender, RoutedEventArgs e)
      {
         Information infoParameter = new Information();
         infoParameter.Name = NameTextBox.Text;
         infoParameter.Email = EmailTextBox.Text;
         infoParameter.PhoneNumber = PhoneNumberTextBox.Text;
         Frame.Navigate(typeof(ContactInfoPage), infoParameter); //Điều hướng sang ContactInfoPage với tham số
      }
   }

   public class Information //Tạo 1 cấu trúc để lưu các thông tin
   {
      public string Name { get; set; } = "ABC"; //Property với tham số mặc định
      public string Email { get; set; } = "abc@fetel.hcmus.edu.vn";
      public string PhoneNumber { get; set; } = "0123456789";
   }
}
