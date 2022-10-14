using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialClass
{

    //methods
    public partial class StudentDetails
    {
         public void showStudent()
        {
            System.Console.WriteLine($" Student ID\t:{StudentId}");
            //showDetails();
            System.Console.WriteLine($" Department\t:{Department}\n Year\t\t:{Year}");
        }
    }
}