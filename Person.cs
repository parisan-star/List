using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Information
{
     public class Person
    {
         public string Name { get; set; }
         public string LastName { get; set; }
         public int NationalCode { get; set; }
         public string Gender { get; set; }
         public String FullName
         {
             get
             {
                 return Name + "   " + LastName;
             }
         }
      

    }
}
