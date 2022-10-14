
using Outside;

namespace Inside;

class Program
{
    public static void Main(string[] args)
    {
        First one=new First();
        Third three = new Third();
        System.Console.WriteLine(one.publicNumber);
        System.Console.WriteLine(one.privateOutput);
        System.Console.WriteLine(one.InternalNumber);
        Second two=new Second();
        System.Console.WriteLine(two.protectedOutput);
        System.Console.WriteLine(one.ProtectedInternalOutput);
       
    }
}