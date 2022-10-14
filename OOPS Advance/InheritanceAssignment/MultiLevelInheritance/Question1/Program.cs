using System;

namespace Question1;

class Program
{
    public static void Main(string[] args)
    {
        HseDetails marksheet=new HseDetails("Franklin","Joseph","Muthu@gmail.com",Gender.Male,123456789,new DateTime(2001,01,17),"Twelth","Bio-Maths",2018,78,78,78,234,78);
        marksheet.Show();
        marksheet.ShowHse();
    }
}