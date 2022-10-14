using System;

namespace ExceptionHandling;

class Program
{
    public static void Main(string[] args)
    {
       
       try
        {
             System.Console.WriteLine("Enter first number");
        int number1=int.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter second number");
        int number2=int.Parse(Console.ReadLine());

        int add=number1+number2;
        int subtract=number1-number2;
             int div=number1/number2;
        }
        catch (DivideByZeroException e)
        {
            System.Console.WriteLine($"Exception occured{e.Message},{e.StackTrace}");
        }
        catch(FormatException e)
        {
            System.Console.WriteLine($"Exception occured{e.Message},{e.StackTrace}");
        }
        catch(System.Exception e)
        {
             System.Console.WriteLine($"Exception occured {e.StackTrace}");
        }
        finally
        {
           System.Console.WriteLine("All exception Handles Properly");
        }
    }
}
