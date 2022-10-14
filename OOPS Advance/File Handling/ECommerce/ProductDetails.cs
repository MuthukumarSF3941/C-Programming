using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce
{
    public class ProductDetails
    {
        static int s_prodctId=1000;

        public string ProductId { get; set; }

        public string  ProductName { get; set; }

        public double Price { get; set; }

        public int Stock { get; set; }

        public int ShippingDuration { get; set; }


        public ProductDetails(string productName,double price,int stock,int shipingDuraion)
        {
            s_prodctId++;
            ProductId="PID"+s_prodctId;
           ProductName=productName;
           Price=price;
           Stock=stock;
           ShippingDuration=shipingDuraion;
        }

             public ProductDetails(string data)
        {

            string[] value=data.Split(',');
            
             ProductId=value[0];
            s_prodctId=int.Parse(value[0].Remove(0,3));
           ProductName=value[1];
           Price=double.Parse(value[2]);
           Stock=int.Parse(value[3]);
           ShippingDuration=int.Parse(value[4]);
        }
       
    }
}