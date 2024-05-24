using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;
using Windows.UI.Xaml.Controls;

namespace Interface
{
   internal class Circle : IDraw, IColor
   {
      private int diameter;
      private int locX = 0, locY = 0;
      private Ellipse circle = null;
      public Circle(int diameter)
      {
         this.diameter = diameter;
      }
      public void SetLocation(int xCoord, int yCoord)
      {
         this.locX = xCoord;
         this.locY = yCoord;
      }
      public void Draw(Canvas canvas)
      {
         if (this.circle != null)
         {
            canvas.Children.Remove(this.circle);//Xóa đối tượng
         }
         else
         {
            this.circle = new Ellipse();
         }
         this.circle.Height = this.diameter;
         this.circle.Width = this.diameter;
         Canvas.SetTop(this.circle, this.locY);
         Canvas.SetLeft(this.circle, this.locX);
         canvas.Children.Add(this.circle);
      }
      public void SetColor(Color color)
      {
         if (this.circle != null)
         {
            SolidColorBrush brush = new SolidColorBrush(color);
            this.circle.Fill = brush;
         }
      }
   }
}
