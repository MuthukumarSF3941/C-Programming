using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;


namespace ECommerce
{
    public static class Files
    {
          public static void Create()
          {
            if(!Directory.Exists("Ecommerce"))
            {
               Directory.CreateDirectory("Ecommerce");
            }

            if(!File.Exists("Ecommerce/Customer.csv"))
            {
                File.Create("Ecommerce/Customer.csv");
            }

            if(!File.Exists("Ecommerce/Orders.csv"))
            {
                File.Create("Ecommerce/Orders.csv");
            }

            if(!File.Exists("Ecommerce/Products.csv"))
            {
                File.Create("Ecommerce/Products.csv");
            }
          }

         public static void ReadData()
          {
            string[] customers=File.ReadAllLines("Ecommerce/Customer.csv");
             foreach(string data in customers)
            {
                CustomerDetails customer=new CustomerDetails(data);
                Operation.customerList.Add(customer);
            }

              string[] products=File.ReadAllLines("Ecommerce/Products.csv");
             foreach(string data in products)
            {
                ProductDetails product=new ProductDetails(data);
                Operation.productList.Add(product);
            }

              string[] orders=File.ReadAllLines("Ecommerce/Orders.csv");
             foreach(string data in orders)
            {
                OrderDetails order=new OrderDetails(data);
                Operation.orderList.Add(order);
            }
          }

          public static void WriteData()
          {
               string[] CustomerDetails=new string[Operation.customerList.Count];

               for (int i = 0; i < Operation.customerList.Count; i++)
               {
                 CustomerDetails[i]=Operation.customerList[i].CustomerId+","+Operation.customerList[i].CustomerName+","+Operation.customerList[i].City+","+Operation.customerList[i].Mobile+","+Operation.customerList[i].Email+","+Operation.customerList[i].WalletAmount;
               }
               File.WriteAllLines("Ecommerce/Customer.csv",CustomerDetails);

               string[] ProductDetails=new string[Operation.productList.Count];

               for (int i = 0; i < Operation.productList.Count; i++)
               {
                 ProductDetails[i]=Operation.productList[i].ProductId+","+Operation.productList[i].ProductName+","+Operation.productList[i].Price+","+Operation.productList[i].Stock+","+Operation.productList[i].ShippingDuration;
               }
               File.WriteAllLines("Ecommerce/Products.csv",ProductDetails);

               string[] OrderDetails=new string[Operation.orderList.Count];
               for (int i = 0; i < Operation.orderList.Count; i++)
               {
                  OrderDetails[i]=Operation.orderList[i].OrderId+","+Operation.orderList[i].CustomerName+","+Operation.orderList[i].CustomerId+","+Operation.orderList[i].ProductId+","+Operation.orderList[i].TotalPrice+","+Operation.orderList[i].PurchaseDate+","+Operation.orderList[i].Quantity+","+Operation.orderList[i].OrderStatus;
               }
               File.WriteAllLines("Ecommerce/Orders.csv",OrderDetails);
          }
    }
}