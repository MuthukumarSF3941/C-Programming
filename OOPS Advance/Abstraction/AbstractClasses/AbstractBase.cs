using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractClasses
{
    public abstract class AbstractBase             //abstract class
    {
        protected string name;       //normal field

        public abstract string Name { get; set; }    //Abstract property

        public double Amount { get; set; }            //normal property

        public void display()                         //normal Maethod
        {
            System.Console.WriteLine("Name\t:"+Name);
        }

        public abstract void salary(int dates);   //Abstract method
        
        
        
        

    }
}