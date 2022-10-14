using System;

namespace Employment;

class Program
{
    public static void Main(string[] args)
    {
        PersonalDetails personal=new PersonalDetails("Muthu kumar","Franklin",9566503260,Gender.Male);
        personal.showDetails();
    }
}
