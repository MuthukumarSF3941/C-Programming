using System;


namespace EbBillCalculator
{

    
    public class CustomerDetails
    {
        static int s_meterId=1000;
        public string Name { get; set; }
        public string MeterId { get; set; }

        public long Phone { get; set; }

        public string Email { get; set; }

        public int Units { get; set; }


         public CustomerDetails()
         {

         }
        public CustomerDetails(string name,string email,long phone)
        {
            s_meterId++;
          Name=name;
          MeterId="EB"+s_meterId;
          Email=email;
          Phone=phone;
          


        }

      public void ShowDetails()
      {
        System.Console.WriteLine($" Customer Name:{Name}\n Meter Id:{MeterId}\n E-Mail;{Email}\n Phone Number:{Phone}\n Units Used:{Units}");
      }

      public void EnterUnits()
      {
        System.Console.WriteLine("Enter units used");
        Units=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Units used"+Units);
      }
        public void BillAmount(int a)
        {
            int billAmount;
            if(a<=100)
            {
                 billAmount=0;
               
            }
            else if (a>100 && a<200)
            {
                billAmount=a*3;
            }
            else if (a>=200 && a<300)
            {
                billAmount=a*4;
            }
            else if (a>=300 && a<400)
            {
                billAmount=a*5;
            }
            else
            {
                billAmount=a*6;
            }
              System.Console.WriteLine("Total bill needed to pay is:"+billAmount);
        }
        
        
        
        
        
        
        
        
        
        
    }
}