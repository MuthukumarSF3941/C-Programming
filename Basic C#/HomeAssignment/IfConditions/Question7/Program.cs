using System;

namespace Question7;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter customer name");
        string cName=Console.ReadLine();
        
        System.Console.WriteLine("Enter customer ID");
        int cId=Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("Enter units consumed");
        int units=Convert.ToInt32(Console.ReadLine());
        
        double charge;
        double surcharge;
        double billAmount;
        
        if (units>0 && units<=50)
        {
            charge=0;
            surcharge=0;
            billAmount=100;
            System.Console.WriteLine($"customer Name:{cName}\n customer ID:{cId}\n units consumed:{units}\n Amount charges={charge}\n surcharge Amount:{surcharge}\n Net Amount paid by the customer:{billAmount} ");
        }
        else if (units>50 && units<=199)
        {
            charge=1.20*units;
            surcharge=0;
            billAmount=charge;
            System.Console.WriteLine($"customer Name:{cName}\n customer ID:{cId}\n units consumed:{units}\n Amount charges={charge}\n surcharge Amount:{surcharge}\n Net Amount paid by the customer:{billAmount} ");
        }
        else if (units>=200 && units<400)
        {
            charge=1.50*units;
            surcharge=0;
            billAmount=charge;
            System.Console.WriteLine($"customer Name:{cName}\n customer ID:{cId}\n units consumed:{units}\n Amount charges={charge}\n surcharge Amount:{surcharge}\n Net Amount paid by the customer:{billAmount} ");
        }
        else if (units>=400 && units<600)
        {
            charge=1.80*units;
            surcharge=charge*0.15;
            billAmount=charge+surcharge;
            System.Console.WriteLine($"customer Name:{cName}\n customer ID:{cId}\n units consumed:{units}\n Amount charges={charge}\n surcharge Amount:{surcharge}\n Net Amount paid by the customer:{billAmount} ");
        }
        else if (units>=600)
        {
            charge=2*units;
            surcharge=charge*0.15;
            billAmount=charge+surcharge;
            System.Console.WriteLine($"customer Id:{cId}\n customer name:{cName}\n units consumed:{units}\n Amount Charges={charge}\n surcharge Amount:{surcharge}\n Net Amount paid by the customer:{billAmount} ");
        }
    }
}
