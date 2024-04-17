using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classLab
{
   internal class Director : UserInformation
   {
      public Director(string name, int age, uint id, double baseSalary) : base(name, age, id, baseSalary)
      { }
      public override double GetSalary()
      {
         return BaseSalary * 4;
      }
   }
}
