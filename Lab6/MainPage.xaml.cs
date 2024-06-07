using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Lab6
{
   /// <summary>
   /// An empty page that can be used on its own or navigated to within a Frame.
   /// </summary>
   public sealed partial class MainPage : Page
   {
      public MainPage()
      {
         try
         {
            this.InitializeComponent();
            this.ViewModel = new UserInformationViewModel();
         }
         catch (Exception ex)
         {

         }
      }
      public UserInformationViewModel ViewModel { get; set; }
      public void createButton_Click(object sender, RoutedEventArgs e)
      {
         try
         {
            string name = useNameTextBox.Text;
            uint id = uint.Parse(userIDTextBox.Text);
            uint age = (uint)userAgeSlider.Value;
            ViewModel.DefaultUser = new UserInformation(name, age, id);
            inforTextBlock.Text = ViewModel.DefaultUser.OneLineInformation;
         }
         catch (Exception ex)
         {
            // Handle exceptions
            Console.WriteLine(ex.Message);
         }
      }

   }
}
