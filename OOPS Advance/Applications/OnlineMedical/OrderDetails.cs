using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedical
{
    public enum Status
    {
        Purchased,Cancelled
    }
    public class OrderDetails 
    {
        public static int s_orderId=2000;

        public string OrderId { get; set; }

        public int  MedicineCount { get; set; }

        public DateTime OrderDate { get; set; }

        public Double TotalPrice { get; set; }

        public Status OrderStatus { get; set; }

        public string UserId { get; set; }

        public string MedicineId { get; set; }

        public OrderDetails(string userId,string medicineId,int medicineCount,DateTime orderDate,double totalPrice,Status orderStatus)
        {
            s_orderId++;
            OrderId="OID"+s_orderId;
            UserId=userId;
            MedicineId=medicineId;
            MedicineCount=medicineCount;
            TotalPrice=totalPrice;
            OrderDate=orderDate;
            OrderStatus=orderStatus;
        }

         public OrderDetails(string data)
        {
            string[] value=data.Split(',');
            s_orderId=int.Parse(value[0].Remove(0,3));
            OrderId=value[0];
            UserId=value[1];
            MedicineId=value[2];
            MedicineCount=int.Parse(value[3]);
            TotalPrice=double.Parse(value[4]);
            OrderDate=DateTime.ParseExact(value[5],"dd/MM/yyyy",null);
            OrderStatus=Enum.Parse<Status>(value[6],true);
        }
        
        
        
        



        
        
        
        
        
        
        
        
        
        
        
    }
}