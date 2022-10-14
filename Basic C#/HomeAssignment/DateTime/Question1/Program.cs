using System;

namespace Question1;

class Program
{
    public static void Main(string[] args)
    {
        DateTime[] dates = { DateTime.Now, new DateTime(2016, 8, 16, 9, 28, 0),new DateTime(2011, 5, 28, 10, 35, 0),new DateTime(1979, 12, 25, 14, 30, 0) };
         for (int i = 0; i < dates.Length; i++)
         {
            System.Console.WriteLine($"day:{dates[i].ToString("dd/MM/yyyy")} Time:{dates[i].ToString ("HH:mm:ss")} \nday:{dates[i].ToString("dd/MM/yyyy" )} Time:{dates[i].ToString ("HH:mm:ss tt")}");
         }
    }
}
