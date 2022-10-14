using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGrocery
{
    public class OrderDetails
    {
        private static int s_oredrId=100;

        public string OrderId { get; set; }

        public string BookingId { get; set; }

        public string ProductId { get; set; }

        public Double OrderPrice { get; set; }

        public int ProductCount { get; set; }
        
        

        public OrderDetails(string bookingId,string productId,int count,double orderPrice)
        {
            s_oredrId++;

            OrderId="OID"+s_oredrId;
            BookingId=bookingId;
            ProductId=productId;
            ProductCount=count;
            OrderPrice=orderPrice;
        }

          public OrderDetails(string data)
        {

            string[] value=data.Split(',');
            s_oredrId=int.Parse(value[0].Remove(0,3));

            OrderId=value[0];
            BookingId=value[1];
            ProductId=value[2];
            ProductCount=int.Parse(value[3]);
            OrderPrice=double.Parse(value[4]);
        }

        public void ShowOrder()
        {
            System.Console.WriteLine($"Order Id:{OrderId} Booking Id:{BookingId} ProductID:{ProductId} OrderPrice:{OrderPrice}");
        }
        
        
        
        
        
        
        
        
    }
}