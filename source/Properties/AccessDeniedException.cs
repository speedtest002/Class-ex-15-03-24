using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classLab.Properties
{
   internal class AccessDeniedException: ApplicationException
   {
      public AccessDeniedException() { }
      public AccessDeniedException(string message) : base(message) { }

      public void CheckAccessPermission()
      {

      }
   }
}
