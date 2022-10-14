using System;
using System.IO;


namespace ReadWriteTextFile;

public class Program
{
    public static void Main(string[] args)
    {
        if(!Directory.Exists("TestFolder"))
        {
           Directory.CreateDirectory("TestFolder");
           System.Console.WriteLine("Folder created");
        }
        else
        {
          System.Console.WriteLine("Folder exists");
        }
        if (!File.Exists("TestFolder/Test.txt"))
        {
            File.Create("TestFolder/Test.txt");
            System.Console.WriteLine("file created");

           
        }
        else
        {
            System.Console.WriteLine("File found");
        }
        System.Console.WriteLine("enter option\n 1.Read File Info\n 2.Write Info");
        int option=int.Parse(Console.ReadLine());

        switch (option)
        {
            case 1:
            {
                string line;
                StreamReader sr=null;
                try
                {
                    //pass the file name and file path to the stream reader constructor
                    sr=new StreamReader("TestFolder/Test.txt");
                    // 
                    line=sr.ReadLine();
                    
                    while (line!=null)
                    {
                        System.Console.WriteLine(line);

                        line=sr.ReadLine();
                    }
                }
                catch(Exception e)
                {
                     System.Console.WriteLine("Exception"+e.Message);
                }
                finally
                {
                    if(sr!=null)
                    {
                        System.Console.WriteLine("Executing finally block");
                        sr.Close();
                    }
                }
                  break;
            }
            case 2:
            {
                StreamWriter sw=null;
                try
                {
                    string[] old=File.ReadAllLines("TestFolder/Test.txt");

                      sw=new StreamWriter("testFolder/Test.txt");

                      System.Console.WriteLine("Enter new content to place inside a file" );

                      string info=Console.ReadLine();
                      string old1="";
                      foreach (string text in old)
                      {
                        old1+="\n"+text;
                      }
                      old1+="\n"+info;
                      sw.WriteLine(old1);


                }
                catch(Exception e)
                {
                    System.Console.WriteLine("exception"+e.Message);
                }
                finally
                {
                    System.Console.WriteLine("Finally block");
                    sw.Close();
                }

                break;
            }
            default:
                break;
        }
        
       
        
    }
}
