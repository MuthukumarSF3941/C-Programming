using System;

namespace DateTimeAssignment;

class Program
{
    public static void Main(string[] args)
    {
        DateTime day=new DateTime(2021,08,10,10,40,32);
        System.Console.WriteLine(day.ToString("dd/MM/yyyy HH:mm:ss"));

        
            string date=day.Day.ToString();
            string month=day.Month.ToString();
            string year=day.Year.ToString();
            string hour=day.Hour.ToString();
            string minutes=day.Minute.ToString();
            string seconds=day.Second.ToString();
            System.Console.WriteLine($"date={date}\n month={month}\n year={year}\n hour={hour}\n minute={minutes}\n second={seconds}\n");
        

    }
}
