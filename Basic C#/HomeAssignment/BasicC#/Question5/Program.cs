using System;

namespace Question5;

public class Program

{
 public static void Main(string[] args)
 {
    Console.WriteLine("Enter your physics marks");
    int physics=int.Parse(Console.ReadLine());

    Console.WriteLine("Enter your chemistry marks");
    int chermistry=int.Parse(Console.ReadLine());

    Console.WriteLine("Enter your maths marks");
    int maths=int.Parse(Console.ReadLine());

    int total=(physics+maths+chermistry);
    double percentage=total*100/300;

    Console.WriteLine($"Sum={total}");
    Console.WriteLine($"Percentage={percentage}");

    Console.ReadLine();

 }   
}
