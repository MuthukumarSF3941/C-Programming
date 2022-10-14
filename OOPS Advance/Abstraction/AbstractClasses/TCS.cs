using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractClasses
{
    public class TCS : AbstractBase
    {
        public override string Name{get{return name;} set{name=value;}}

        public override void salary(int dates)
        {
            System.Console.WriteLine("--------TCS--------");
            display();
            Amount=(double)dates*200;
            System.Console.WriteLine("Salary\t:"+Amount);
        }
    }
}