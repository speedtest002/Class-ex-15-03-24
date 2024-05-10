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
   public sealed partial class WHR : Page
   {
      public WHR()
      {
         this.InitializeComponent();
      }
      //string selectedValue;
      //private void GioiTinhComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
      //{
      //   ComboBox gioiTinhComboBox = (ComboBox)sender;
      //   ComboBoxItem selectedComboBoxItem = (ComboBoxItem)gioiTinhComboBox.SelectedItem;
      //   selectedValue = selectedComboBoxItem.Content.ToString();
      //}

      private void TinhToanButton_Click(object sender, RoutedEventArgs e)
      {
         try
         {
            var selectedItem = gioiTinh.SelectedItem;
            if (selectedItem == null)
            {
               throw new Exception("Hãy chọn giới tính");
            }
            var selectedValue = ((ComboBoxItem)gioiTinh.SelectedItem).Content.ToString();
            double vongEo = double.Parse(vongEoTextBox.Text);
            double vongHong = double.Parse(vongHongTextBox.Text);
            double whr = vongEo / vongHong;
            whrTextBox.Text = whr.ToString();
            if (selectedValue == "Nam")
            {
               switch (whr)
               {
                  case double value when value < 0.9:
                     nguyHiemTextBox.Text = "Thấp";
                     hinhDangTextBox.Text = "Quả Lê";
                     break;
                  case double value when value >= 0.9 && value <= 1.0:
                     nguyHiemTextBox.Text = "Trung Bình";
                     hinhDangTextBox.Text = "Quả Bơ";
                     break;
                  case double value when value > 1.0:
                     nguyHiemTextBox.Text = "Cao";
                     hinhDangTextBox.Text = "Quả Táo ";
                     break;
                  default:
                     nguyHiemTextBox.Text = "NaN";
                     hinhDangTextBox.Text = "NaN";
                     break;
               }
            }
            else
            {
               switch (whr)
               {
                  case double value when value < 0.80:
                     nguyHiemTextBox.Text = "Thấp";
                     hinhDangTextBox.Text = "Quả Lê";
                     break;
                  case double value when value >= 0.81 && value <= 0.85:
                     nguyHiemTextBox.Text = "Trung Bình";
                     hinhDangTextBox.Text = "Quả Bơ";
                     break;
                  case double value when value > 0.85:
                     nguyHiemTextBox.Text = "Cao";
                     hinhDangTextBox.Text = "Quả Táo ";
                     break;
                  default:
                     nguyHiemTextBox.Text = "NaN";
                     hinhDangTextBox.Text = "NaN";
                     break;
               }
            }
            ErrorTextBlock.Visibility = Visibility.Collapsed;
         }
         catch (FormatException)
         {
            ErrorTextBlock.Text = "Hãy nhập vào một con số";
            whrTextBox.Text = "Error: NaN";
            ErrorTextBlock.Visibility = Visibility.Visible;
         }
         catch (Exception ex)
         {
            ErrorTextBlock.Text = ex.Message;
            whrTextBox.Text = "Error: NaN";
            ErrorTextBlock.Visibility = Visibility.Visible;
         }
      }  
   }
}
