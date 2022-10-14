using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VirtualOverride 
{
    public class Puppy : Dog
    {
        public override void makeSound()
        {
            System.Console.WriteLine("Puppy sound");
        }
    }
}