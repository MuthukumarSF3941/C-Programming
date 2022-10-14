using System;

namespace OperatorOverloading;

class Program
{
    public static void Main(string[] args)
    {
        Box box1=new Box(1.2,3.2,3.4);
        Box box2=new Box(10.1,11.1,12.2);
        Box box3=new Box(13.2,8.4,6.2);

        //volume box1
        double volume1=box1.CalculateVolume();
        System.Console.WriteLine("Volume of Box1:"+volume1);

        //volume box1
         double volume2=box2.CalculateVolume();
        System.Console.WriteLine("Volume of Box2:"+volume2);

        // box1+box2
        box3=box1+box2;
        box3.Add(box1,box2);
        System.Console.WriteLine(box3);

        //volume of box3
          double volume3=box3.CalculateVolume();
        System.Console.WriteLine("Volume of Box3:"+volume3);
         

    }
}
