using System;

namespace classLab
{
   internal class Point
   {
      private int x, y;
      public static uint objectCount = 0;
      public Point(int x, int y)
      {
         this.x = x;
         this.y = y;
         objectCount++;
      }
      public Point()
      {
         x = 0;
         y = 0;
         objectCount++;
      }
      public double DistanceTo(Point otherPoint)
      {
         int deltaX = otherPoint.x - x;
         int deltaY = otherPoint.y - y;
         return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
      }
      public static uint ObjectCount()
      {
         return objectCount;
      }
   }
}