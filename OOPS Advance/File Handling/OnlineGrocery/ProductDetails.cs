using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGrocery
{
    public class ProductDetails
    {
        private static int s_prodiuctId=100;

        public string ProductId { get; set; }

        public string ProductName { get; set; }

        public int AvailableQuantity { get; set; }

        public double Price { get; set; }

        public ProductDetails(string productName,int quantity,double price)
        {
            s_prodiuctId++;
            ProductId="PID"+s_prodiuctId;
            ProductName=productName;
            AvailableQuantity=quantity;
            Price=price;
        }

         public ProductDetails(string data)
        {
            string[] value=data.Split(',');
            s_prodiuctId=int.Parse(value[0].Remove(0,3));
            ProductId=value[0];
            ProductName=value[1];
            AvailableQuantity=int.Parse(value[2]);
            Price=double.Parse(value[3]);
        }

        public void ShowProductDetails()
        {
            System.Console.WriteLine($"ProductId:{ProductId}\t ProductName:{ProductName}\t Available Quantity:{AvailableQuantity}\t  Price Per Order:{Price}");
        }
        
        
        
        
        
        
        
        
    }
}