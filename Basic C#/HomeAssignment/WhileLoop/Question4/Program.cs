using System;

namespace Question4;

class Program
{
    public static void Main(string[] args)
    {
        int input;
        
            System.Console.WriteLine("enter the number");
             bool temp=int.TryParse(Console.ReadLine(),out input);
        while(!temp)
        {
                
                System.Console.WriteLine("Invalid input enter again");
             bool value=int.TryParse(Console.ReadLine(),out input);

            while(value)
            {  
              if (input>=1 && input<=5)
                {
                  System.Console.WriteLine("valid input");
                  value=false;
               
                }
              else
                {
                 System.Console.WriteLine("Invalid input enter again");
                 temp=false;

              
                }
            }

        }
            
        }
    }
