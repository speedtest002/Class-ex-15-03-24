using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Interface
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DrawingPad : Page
    {
        public DrawingPad()
        {
            this.InitializeComponent();
        }

      private void drawingCanvas_Tapped(object sender, TappedRoutedEventArgs e)
      {
         Point mouseLocation = e.GetPosition(this.drawingCanvas); //Xác định vị trí của con trỏ
         Square mySquare = new Square(100); //Tạo một đối tượng Square
         if (mySquare is IDraw) //Kiểm tra mySquare khi hiện thực giao diện IDraw
         {
            IDraw drawSquare = mySquare;
            drawSquare.SetLocation((int)mouseLocation.X, (int)mouseLocation.Y);
            drawSquare.Draw(drawingCanvas);
         }
         if (mySquare is IColor) ////Kiểm tra mySquare khi hiện thực giao diện IColor
         {
            IColor colorSquare = mySquare;
            colorSquare.SetColor(Colors.BlueViolet); //Set màu cho đối tượng
         }
      }

      private void drawingCanvas_RightTapped(object sender, RightTappedRoutedEventArgs e)
      {
         Point mouseLocation = e.GetPosition(this.drawingCanvas); //Xác định vị trí của con trỏ
         Circle myCircle = new Circle(100); //Tạo một đối tượng Square
         if (myCircle is IDraw) //Kiểm tra mySquare khi hiện thực giao diện IDraw
         {
            IDraw drawCircle = myCircle;
            drawCircle.SetLocation((int)mouseLocation.X, (int)mouseLocation.Y);
            drawCircle.Draw(drawingCanvas);
         }
         if (myCircle is IColor) ////Kiểm tra mySquare khi hiện thực giao diện IColor
         {
            IColor colorSquare = myCircle;
            colorSquare.SetColor(Colors.Cyan); //Set màu cho đối tượng
         }
      }
   }
}
