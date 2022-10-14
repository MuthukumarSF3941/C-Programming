using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce
{
    public class CustomerDetails
    {

        static int s_customerId=1000;

        public string CustomerId { get; set; }

        public string CustomerName { get; set; }

        public string City { get; set; }

        public long Mobile { get; set; }

        public string Email { get; set; }

        public double WalletAmount { get; set; }

        public CustomerDetails(string customerName,string city,long mobile,string eMail,double walletAmount)
        {
            s_customerId++;
            CustomerId="CID"+s_customerId;
            CustomerName=customerName;
            City=city;
            Mobile=mobile;
            Email=eMail;
            WalletAmount=walletAmount;

        }

        public CustomerDetails(string data)
        {
            string[] value=data.Split(',');
           
            CustomerId=value[0];
             s_customerId=int.Parse(value[0].Remove(0,3));
             CustomerName=value[1];
            City=value[2];
            Mobile=long.Parse(value[3]);
            Email=value[4];
            WalletAmount=double.Parse(value[5]);

        }
       
    }
}