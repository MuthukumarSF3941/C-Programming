using System;

namespace Question2;

class Program
{
    public static void Main(string[] args)
    {
        AccountInfo account=new AccountInfo("Franklin","Joseph","muthuempire20012gmail.com",Gender.Male,98865544,new DateTime(2001,01,17),"SBI23456789",500);
        account.showPersonal();
        account.show();

    }
}