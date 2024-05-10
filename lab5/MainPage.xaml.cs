using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace lab5
{
   /// <summary>
   /// An empty page that can be used on its own or navigated to within a Frame.
   /// </summary>
   public sealed partial class MainPage : Page
   {
      public MainPage()
      {
         this.InitializeComponent();
         MyFrame.Navigate(typeof(BMI));
      }
      private void BMIButton_Click(object sender, RoutedEventArgs e)
      {
         if(MyFrame.CurrentSourcePageType != typeof(BMI))
            MyFrame.Navigate(typeof(BMI));
      }
      private void WHRButton_Click(object sender, RoutedEventArgs e)
      {
         if (MyFrame.CurrentSourcePageType != typeof(WHR))
            MyFrame.Navigate(typeof(WHR));
      }
   }
}
