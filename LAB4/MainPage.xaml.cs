using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace LAB4
{
   /// <summary>
   /// An empty page that can be used on its own or navigated to within a Frame.
   /// </summary>
   public sealed partial class MainPage : Page
   {
      public MainPage()
      {
         this.InitializeComponent();
      }

      private void ClickMeButton_Click(object sender, RoutedEventArgs e)
      {
         int IQ;
         try
         {
            IQ = int.Parse(IQTextBox.Text);
            if (IQ < 85)
            {
               DisplayTextBlock.Text = "Thấp";
            }
            else if(IQ < 115)
            {
               DisplayTextBlock.Text = "Bình thường";
            }
            else if(IQ < 130)
            {
               DisplayTextBlock.Text = "Thông minh";
            }
            else if (IQ < 145)
            {
               DisplayTextBlock.Text = "Rất thông minh";
            }
            else
            {
               DisplayTextBlock.Text = "Thiên tài";
            }
            ErrorTextBlock.Visibility = Visibility.Collapsed;
         }
         catch (FormatException)
         {
            ErrorTextBlock.Text = "Hãy nhập vào một số nguyên";
            DisplayTextBlock.Text = "Error: NaN";
            ErrorTextBlock.Visibility = Visibility.Visible;
         }
      }
   }
}
