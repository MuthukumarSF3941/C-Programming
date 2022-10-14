using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce
{

    public enum Status{Ordered,Cancelled};
    public class OrderDetails
    {
        static int s_OrderId=100;

        public string  OrderId { get; set; }

        public string CustomerName { get; set; }

        public string CustomerId { get; set; }

        public string ProductId { get; set; }
        
        


        public double TotalPrice { get; set; }

        public DateTime PurchaseDate { get; set; }

        public int Quantity { get; set; }

        public Status OrderStatus { get; set; }

        public OrderDetails(string customerId,string customerName,string productId,double totalPrice,DateTime purchaseDate,int quantity,Status orderStatus)
        {
            s_OrderId++;
            OrderId="OID"+s_OrderId;
            CustomerName=customerName;
            CustomerId=customerId;
            ProductId=productId;
            TotalPrice=totalPrice;
            PurchaseDate=purchaseDate;
            Quantity=quantity;
            OrderStatus=orderStatus;


        }

        public OrderDetails(string data)
        {

            string[] value=data.Split(',');
               OrderId=value[0];
            s_OrderId=int.Parse(value[0].Remove(0,3));
         
            CustomerName=value[1];
            CustomerId=value[2];
            ProductId=value[3];
            TotalPrice=double.Parse(value[4]);
            PurchaseDate=DateTime.Parse(value[5]);
            Quantity=int.Parse(value[6]);
            OrderStatus=Enum.Parse<Status>(value[7]);


        }
      

    }
}