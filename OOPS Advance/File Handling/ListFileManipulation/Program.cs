using System;
using System.Collections.Generic;
using System.IO;

namespace ListFileManipulation;

class Program
{
    public static void Main(string[] args)
    {
     List<StudentDetails> studentList=new List<StudentDetails>();

     studentList.Add(new StudentDetails(){Name="Franklin",FatherName="Joseph",DOB=new DateTime(2001,01,16),Gender=Gender.Male});
     studentList.Add(new StudentDetails(){Name="Antony",FatherName="Justin",DOB=new DateTime(2000,10,18),Gender=Gender.Male});
     studentList.Add(new StudentDetails(){Name="Joseph",FatherName="Frank",DOB=new DateTime(2011,11,16),Gender=Gender.Male});
     studentList.Add(new StudentDetails(){Name="Mary",FatherName="Bosco",DOB=new DateTime(2001,01,29),Gender=Gender.Female});
     studentList.Add(new StudentDetails(){Name="John",FatherName="Ralph",DOB=new DateTime(2002,03,30),Gender=Gender.Male});
     Program.Insert(studentList);
     Program.Display();
    }
     static void Insert(List<StudentDetails> studentList)
     {
       StreamWriter write=null;

       if(!File.Exists("Data.csv"))
       {
        System.Console.WriteLine("File not exist. creating a new csv file");
        File.Create("Data.csv");
       }
       else
       {
           System.Console.WriteLine("File found");
       }
       write=new StreamWriter(File.OpenWrite("Data.csv"));

       foreach (var v in studentList)
       {
        write.WriteLine(v.Name+","+v.FatherName+","+v.Gender+","+v.DOB.ToShortDateString());
       }
       write.Close();
     
    }
    static void Display()
    {
        StreamReader reader=null;
        List<StudentDetails> studentList=new List<StudentDetails>();

        if(File.Exists("Data.csv"))
        {
            reader=new StreamReader(File.OpenRead("Data.csv"));
            while(!reader.EndOfStream)
            {
                var line=reader.ReadLine();
                var values=line.Split(',');
                if(values[0]!="")
                {
                    studentList.Add(new StudentDetails(){Name=values[0],FatherName=values[1],Gender=Enum.Parse<Gender>(values[2]),DOB=DateTime.ParseExact(values[3],"dd/MM/yyyy",null)});
                }
              
            }
        }
          else
                {
                  System.Console.WriteLine("file not Exist");
                }
                reader.Close();
                int i=1;
                foreach (var column1 in studentList)
                {
                    System.Console.WriteLine($"--------------------------ROW:{i}------------------------------");
                    i++;
                    System.Console.WriteLine($"Name:{column1.Name}\t Father name:{column1.FatherName}\t DOB:{column1.DOB.ToShortDateString()}\t Gender:{column1.Gender}");
                }
    }
}