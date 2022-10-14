using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce
{
    public static class Operation
    {
        public static List<CustomerDetails> customerList=new List<CustomerDetails>();

        public static CustomerDetails currentCustomer=null;

         public static List<OrderDetails> orderList=new List<OrderDetails>();

        public static List<ProductDetails> productList=new List<ProductDetails>();

        

        public static void MainMenu()
        {
            int choice;

            do
            {
                System.Console.WriteLine("Enter your Choice  1.Registration\t 2.Login and Purchase\t 3.Exit");
                 choice=int.Parse(Console.ReadLine());

                 switch (choice)
                 {
                    case 1:
                    {
                        System.Console.WriteLine("Registration");
                        Registration();
                         break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("Login and Purchase");
                        Login();
                         break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("Exit");
                         break;
                    }
                       
                    default:
                    System.Console.WriteLine("Invalid Input");
                        break;
                 }
                 
            } while (choice!=3);
        }

        public static void Registration()
        {
            System.Console.WriteLine("Enter your Name");
            string customerNmae=Console.ReadLine();
            
            System.Console.WriteLine("Enter Your City");
            string city=Console.ReadLine();
            
            System.Console.WriteLine("Enter your Mobile Number");
            long mobile=long.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter Your E-Mail ID");
            string eMail=Console.ReadLine();

            System.Console.WriteLine("Enter initial Wallet Recharge Amount");
            double walletAmount=double.Parse(Console.ReadLine());

            CustomerDetails customers=new CustomerDetails(customerNmae,city,mobile,eMail,walletAmount);
            customerList.Add(customers);

            
            System.Console.WriteLine($"your customer ID is:{customers.CustomerId}");

        }
          public static void Login()
        {
            System.Console.WriteLine("Enter customerId");
            string customerId=Console.ReadLine().ToUpper();
            
            foreach (CustomerDetails customer in customerList)
            {
                if(customer.CustomerId==customerId)
                {
                    System.Console.WriteLine("Login Sucessfull");
                    currentCustomer=customer;
                    subMenu();
                    
    
                }
            }
        }


          
          public static void subMenu()

          {
            int choice;
            do
            {
                System.Console.WriteLine("Enter Your choice  1.Purchase\t 2.Order History\t 3.Cancel Order\t 4.Wallet Balance\t 5.Exit SubMenu");
                 choice=int.Parse(Console.ReadLine());

                 switch (choice)
                 {
                    case 1:
                    {
                        System.Console.WriteLine("Purchase");
                        purchase();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("Order History");
                        OrderHistory();
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("Cancel Order");
                        cancelOrder();
                        break;
                    }
                    case 4:
                    {
                        System.Console.WriteLine("Wallet Balance");
                        Balance();
                        break;
                    }
                    case 5:
                    {
                        System.Console.WriteLine("Exit SubMenu");
                        break;
                    }
                          
                    default:
                    System.Console.WriteLine("Invalid Entry");
                        break;
                 }
                 
                
            } while (choice!=5);
          }

        public static void purchase()
        {
          showProduct();
          System.Console.WriteLine("Enter Product Id");
          string ProductId=Console.ReadLine().ToUpper();

          foreach (ProductDetails product in productList)
          {
            if(ProductId==product.ProductId)
            {
                
                System.Console.WriteLine("Enter the Quantity");
                int quantity=int.Parse(Console.ReadLine());
                if(quantity<=product.Stock)
                {
                     int delivery=50;
                     double totalPrice=(quantity*product.Price)+delivery;
                     foreach (CustomerDetails customer5 in customerList)
                     {
                        if(customer5.CustomerId==currentCustomer.CustomerId)
                        {
                            if(customer5.WalletAmount>=totalPrice)
                            {
                                System.Console.WriteLine("order Booked");
                                OrderDetails order=new OrderDetails(customer5.CustomerId,customer5.CustomerName,product.ProductId,totalPrice,DateTime.Now,quantity,Status.Ordered);
                                orderList.Add(order);
                                
                                System.Console.WriteLine($"your Purchse Id is:{order.OrderId}");
                                System.Console.WriteLine($"your order is placed product is delivered :{DateTime.Now.AddDays(product.ShippingDuration)}");
                                product.Stock-=quantity;
                                customer5.WalletAmount-=totalPrice;
                            }
                            else
                            {
                                 System.Console.WriteLine("Insufficient balance plese Recharge");
                            }
                           
                        }
                        
                     }
                     {

                     }
                }
                else
                {
                    System.Console.WriteLine("No available stocks");
                }
              
            }
          }
          
        }

        public static void showProduct()
        {
            foreach (ProductDetails product in productList)
            {
                System.Console.WriteLine($"Product Id:{product.ProductId}\t Product Name:{product.ProductName}\t Available Stock:{product.Stock}\t Price perQuantity;{product.Price}\t ShippingDuration:{product.ShippingDuration}");
            }
        }
        public static void defaultValues()
        {
            CustomerDetails customer1=new CustomerDetails("Ravi","chenni",9885858588,"Ravi@Gamil.com",50000);
            customerList.Add(customer1);

            CustomerDetails customer2=new CustomerDetails("Baskaran","chenni",9888475757,"Baskaran@Gamil.com",60000);
            customerList.Add(customer2);

            ProductDetails Product1=new ProductDetails("Mobile",10000,10,3);
            productList.Add(Product1);

             ProductDetails Product2=new ProductDetails("Tablet",15000,5,2);
            productList.Add(Product2);

             ProductDetails Product3=new ProductDetails("Camera",20000,3,4);
            productList.Add(Product3);

             ProductDetails Product4=new ProductDetails("IPhone",50000,5,6);
            productList.Add(Product4);

             ProductDetails Product5=new ProductDetails("Laptop",40000,3,3);
            productList.Add(Product5);

            OrderDetails order1=new OrderDetails(customer1.CustomerId,customer1.CustomerName,Product1.ProductId,20000,DateTime.Now,2,Status.Ordered);
            orderList.Add(order1);
            Product1.Stock-=order1.Quantity;

            OrderDetails order2=new OrderDetails(customer2.CustomerId,customer2.CustomerName,Product3.ProductId,40000,DateTime.Now,2,Status.Ordered);
            orderList.Add(order2);
            Product3.Stock-=order2.Quantity;
        }
        
        public static void OrderHistory()
    {
      
         foreach (CustomerDetails item in customerList)
       {
        if(item.CustomerId==currentCustomer.CustomerId)
        {
            foreach (OrderDetails order in orderList)
            {
                if(order.CustomerId==currentCustomer.CustomerId)
                {
                    foreach (ProductDetails product in productList)
                    {
                        if(product.ProductId==order.ProductId)
                        {
                            System.Console.WriteLine($"order ID:{order.OrderId} CustomerID:{order.CustomerId}\t Product Id;{order.ProductId}\t Total Price:{order.TotalPrice}\t Purchase Date:{order.PurchaseDate}\t Quantity:{order.Quantity}, Order Status:{order.OrderStatus}");
                        }
                    }
                }
            }
        }
       }
      
    }

       public static void cancelOrder()
       {
        OrderHistory();
        System.Console.WriteLine("Enter Your OrderId");
        string orderId=Console.ReadLine().ToUpper();

       foreach (CustomerDetails customer in customerList)
       {
        if (customer.CustomerId==currentCustomer.CustomerId)
        {
             foreach (OrderDetails order in orderList)
        {
            if(orderId==order.OrderId)
            {
                foreach (ProductDetails product in productList)
                {
                    if(product.ProductId==order.ProductId)
                    {
                       if (order.OrderStatus==Status.Ordered)
                       {
                        order.OrderStatus=Status.Cancelled;
                        product.Stock+=order.Quantity;
                        currentCustomer.WalletAmount+=order.TotalPrice+50;
                        System.Console.WriteLine("Order cancelled");
                       }
                       else
                       {
                        System.Console.WriteLine("Already Cancelled");
                       }
                    }
                }
            }
        }
        }
       }
        

       }
    
       public static void Balance()
       {
        System.Console.WriteLine("Enter ampunt to Recharge");
        double amount=double.Parse(Console.ReadLine());
        foreach (CustomerDetails customer in customerList)
        {
            if(customer.CustomerId==currentCustomer.CustomerId)
            {
                currentCustomer.WalletAmount+=amount;
                System.Console.WriteLine($"total balance is:{currentCustomer.WalletAmount}");
            }
        }
       }

    }
}