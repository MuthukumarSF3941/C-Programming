
namespace CustomerDetailsLibrary
{
    public class CustomerDetails
    {
        public string Name { get; set; }
        public string MeterId { get; set; }

        public long Phone { get; set; }

        public string Email { get; set; }

        public int Units { get; set; }

        public CustomerDetails(string name,string meterId,string email,long phone,int units)
        {
          Name=name;
          MeterId=meterId;
          Email=email;
          Phone=phone;
          Units=units;


        }
        public int BillAmount(int a)
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
             return billAmount;
        }
        
        
        
        
        
        
        
        
        
        
    }
}