using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractClasses
{
    public class SyncFusion : AbstractBase
    {
        public override string Name{get{return name;} set{name=value;}}

        public override void salary(int dates)
        {
            System.Console.WriteLine("-------SyncFusion--------");
            display();
            Amount=(double)dates*500;
            System.Console.WriteLine("Salary\t:"+Amount);
        }
    }
}