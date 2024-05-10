using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace lab5
{
   /// <summary>
   /// An empty page that can be used on its own or navigated to within a Frame.
   /// </summary>
   public sealed partial class BMI : Page
   {
      public BMI()
      {
         this.InitializeComponent();
      }
      private void TinhToanButton_Click(object sender, RoutedEventArgs e)
      {
         try
         {
            double chieuCao = double.Parse(chieuCaoTextBox.Text);
            double canNang = double.Parse(canNangTextBox.Text);
            double bmi = canNang / (chieuCao * chieuCao/(100*100));
            double canNangLyTuong = (chieuCao%100) * 9 / 10;
            chiSoBMITextBox.Text = bmi.ToString();
            canNangLyTuongTextBox.Text = canNangLyTuong.ToString();
            switch (bmi)
            {
               case double value when value < 18.5:
                  ketLuanTextBox.Text = "Thiếu cân (gầy)";
                  break;
               case double value when value >= 18.5 && value < 23.0:
                  ketLuanTextBox.Text = "Bình thường";
                  break;
               case double value when value >= 23.0 && value < 25.0:
                  ketLuanTextBox.Text = "Tiền béo phì";
                  break;
               case double value when value >= 25.0 && value < 30.0:
                  ketLuanTextBox.Text = "Béo phì độ I";
                  break;
               case double value when value >= 30.0 && value < 35.0:
                  ketLuanTextBox.Text = "Béo phì độ II";
                  break;
               case double value when value >= 35.0:
                  ketLuanTextBox.Text = "Béo phì độ III";
                  break;
               default:
                  ketLuanTextBox.Text = "NaN";
                  break;
            }
         


            ErrorTextBlock.Visibility = Visibility.Collapsed;
         }
         catch (FormatException)
         {
            ErrorTextBlock.Text = "Hãy nhập vào một con số";
            chiSoBMITextBox.Text = "Error: NaN";
            ErrorTextBlock.Visibility = Visibility.Visible;
         }

      }
   }
}
