using System;
namespace Student;

class Program

{
   public static void Main(string[] args)
   {
    Console.WriteLine("welcom !");
     Console.WriteLine("Enter your name");
     string name=Console.ReadLine();

      Console.WriteLine("Entetr your Father name");
      string fName=Console.ReadLine();

       Console.WriteLine("enter your age");
       int age=int.Parse(Console.ReadLine());

       Console.WriteLine("enter your E-mail ID");
       string eMail=Console.ReadLine();

       Console.WriteLine("enter your mobile number");
       long number=long.Parse(Console.ReadLine());

        Console.WriteLine("enter your gender:");
        string gender=Console.ReadLine();

          Console.WriteLine("enter your pysics marks:");
          int physics=int.Parse(Console.ReadLine());

        Console.WriteLine("enter your chemistry  marks:");
        int chemistry=int.Parse(Console.ReadLine());

        Console.WriteLine("enter your maths marks:");
        int maths=int.Parse(Console.ReadLine());

        float total=physics+maths+chemistry;
        float average=total/3;
        float Percentage=(total/600)*100;



        Console.WriteLine($"name: {name}");
        Console.WriteLine($"Father name : {fName}");
         Console.WriteLine($"mobile :{number}");
          Console.WriteLine($"E-Mail :{eMail}");
           Console.WriteLine($"Age : {age}");
            Console.WriteLine($"Gender: {gender}");
             Console.WriteLine($"Average score:{average}");
              Console.WriteLine($"Percentage : {Percentage}%");

             Console.ReadLine();
             


         


   } 
}

