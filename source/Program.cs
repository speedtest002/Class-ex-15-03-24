using DocumentFormat.OpenXml.Math;
using System;

namespace classLab
{
   partial class Program
   {
      public static void Main()
      {
         try
         {
            Lab3_2();
         }
         catch (AccessDeniedException)
         {
            Console.WriteLine("Access denied!");
         }
         catch (OverflowException ex)
         {
            Console.WriteLine(ex.StackTrace);
         }
         //catch (UserAccountException ex)
         //{
         //    Console.WriteLine(ex.Message);
         //}
         // catch (Exception ex)
         //{
         //    Console.WriteLine(ex.Message);
         //}
         Console.ReadLine();
      }
   }
}
