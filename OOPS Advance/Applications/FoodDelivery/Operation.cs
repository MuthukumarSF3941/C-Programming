using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDelivery
{
    public delegate void EventManager();
    public static class Operation
    {
        public static List<CustomerRegistration> customerList=new List<CustomerRegistration>();

        public static List<FoodDetails> FoodList=new List<FoodDetails>();

        public static List<OrderDetails> orderList=new List<OrderDetails>();

        public static List<BookingDetails> bookingList=new List<BookingDetails>();

         static CustomerRegistration currentCustomer=null;
         public static event EventManager eventlink=null;

          public static void Subscribe()
       {
          eventlink+=new EventManager(Files.Create);
          
          eventlink+=new EventManager(Files.ReadFiles);

          eventlink+=new EventManager(Operation.MainMenu);

          eventlink+=new EventManager(Files.WriteLines);

       }

       public static void StartEvent()
       {
        Subscribe();
        eventlink();
       }

         public static void MainMenu()
         {
            int choice;
            do
            {
                System.Console.WriteLine("Enter your choice\n 1.Customer Registration\n 2.customer login\n 3.Exit");
                 choice=int.Parse(Console.ReadLine());

                 switch (choice)
                 {
                    case 1:
                    {
                        System.Console.WriteLine("---------Registration----------");
                        Registration();
                        break;
                    }

                     case 2:
                    {
                        System.Console.WriteLine("---------Log In----------");
                        login();
                        break;
                    }

                     case 3:
                    {
                        System.Console.WriteLine("Exit main menu");
                        break;
                    }
                        
                    default:
                    System.Console.WriteLine("invalid Entry");
                        break;
                 }
                 
                
            } while (choice!=3);
         }

         public static void Registration()
         {
            System.Console.WriteLine("Enter name");
            string name=Console.ReadLine();
            

            System.Console.WriteLine("Enter your father name");
            string fatherName=Console.ReadLine();
            
            System.Console.WriteLine("Enter your gender");
            Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);

            System.Console.WriteLine("Enter your mobile number");
            long mobile=long.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter your date of Birth");
            DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);

            System.Console.WriteLine("Enter your email id");
            string email=Console.ReadLine();

            System.Console.WriteLine("Enter your location");
            string location=Console.ReadLine();
            
            System.Console.WriteLine("enter wallet amount");
            int wallet=int.Parse(Console.ReadLine());

            CustomerRegistration customer1=new CustomerRegistration(wallet,name,fatherName,gender,mobile,dob,email,location);
            customerList.Add(customer1);

            System.Console.WriteLine($"Your customer RegistrationId is:{customer1.CustomerId}");
             
             
             
             }
        
        public static void login()
        {
            System.Console.WriteLine("Enter your Customer ResgistrationID");
            string userid=Console.ReadLine().ToUpper();
            int flag=0;
            foreach (CustomerRegistration customer in customerList)
            {
                if(customer.CustomerId==userid)
                {
                   System.Console.WriteLine("Log in Successful");
                   flag=1;
                   currentCustomer=customer;
                   SubMenu();
                }
            }
            if(flag==0)
            {
                System.Console.WriteLine("wrong customer ID");
            }
        }

        public static void SubMenu()
        {
             int choice;

             do
             {

                System.Console.WriteLine("Enter your choice\n  1.Show food item Details\n 2.Order Food\n  3.CancelBooking\n 4.Order History\n 5.Wallet Recharge\n 6.Exit");
                choice=int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                    {
                        System.Console.WriteLine("Show food Details");
                        ShowFoods();
                        break;
                    } 

                    case 2:
                    {
                        System.Console.WriteLine("Order Food");
                        TakeOredr();
                        break;
                    }  
                    case 3:
                    {
                        System.Console.WriteLine("Cancel Booking");
                        CancelOredr();
                        break;
                    }  

                    case 4:
                    {
                        System.Console.WriteLine("Order History");
                        ShowOrder();
                        break;
                    }  

                    case 5:
                    {
                        System.Console.WriteLine("Wallet Recharge");
                        currentCustomer.WalletRecarge();
                        break;
                    }   

                    case 6:
                    {
                        System.Console.WriteLine("Exit sub menu");
                        break;
                    } 

                    default:
                        break;
                }
                    
            
                
             } while (choice!=6);
        }

        public static void ShowFoods()
        {
            foreach (FoodDetails food  in FoodList)
            {
                System.Console.WriteLine($"Food Id:{food.FoodId}  Food Name:{food.FoodName} PricePer Quantity:{food.PricePerQuantity}");
            }
        }
         
         public static void TakeOredr()
         {
            string choice="";
            System.Console.WriteLine("Do you want to order food");
            choice=Console.ReadLine().ToLower();

            if(choice=="yes")
            {
                BookingDetails book1=new BookingDetails(currentCustomer.CustomerId,0,DateTime.Now,Status.Initiated);
                List<OrderDetails> orderList1=new List<OrderDetails>();
               
                
                do
                {
                    ShowFoods();
                    System.Console.WriteLine("Enter the foodID");
                    string foodId=Console.ReadLine().ToUpper();

                    System.Console.WriteLine("Enter Quantity");
                    int count=int.Parse(Console.ReadLine());

                    foreach (FoodDetails food in FoodList)
                    {
                        if(food.FoodId==foodId)
                        {
                            
                            int amount=count*food.PricePerQuantity;
                            if(amount<=currentCustomer.WalletAmount)
                            {
                                 System.Console.WriteLine("Oredr placed");
                                 OrderDetails order=new OrderDetails(book1.BookingId,foodId,count,amount);
                               
                                 System.Console.WriteLine($"order placed and order id is {order.OrderId}");
                                 orderList1.Add(order);
                                 

                                 System.Console.WriteLine("Do you want to order more");
                                 choice=Console.ReadLine().ToLower();
                                 

                            }
                            else
                            {
                                  System.Console.WriteLine("Low balance");
                            }
                        }
                    }
                    


                    
                } while (choice=="yes");

                if(choice=="no")
                {
                    System.Console.WriteLine("Do you want to purchase the oredr");
                    choice=Console.ReadLine().ToLower();

                    if(choice=="yes")
                    {
                        int amount=0;
                     foreach (OrderDetails order in orderList)
                       {
                              if (book1.BookingId==order.BookingId)
                           {
                               amount+=order.PriceofOrder;
                         
                            }
                     
                        }
                   
                   book1.BookingStatus=Status.Booked;
                   book1.TotalPrice=amount;
                   currentCustomer.WalletAmount-=amount;
                 
                  System.Console.WriteLine(" order Booked\n booking id is:"+book1.BookingId);
                  bookingList.Add(book1);
                  orderList.AddRange(orderList1);
                  
                 
                  
                    }

                    else
                    {
                        book1.BookingStatus=Status.Cancelled;
                         bookingList.Add(book1);
                    }
                

                }
            }
            
         }
         

         public static void CancelOredr()
         {
            ShowHistory();
            System.Console.WriteLine("Enter the booking Id to cancel");
            string bookId=Console.ReadLine().ToUpper();
            int flag=0;

            foreach(BookingDetails book in bookingList)
            {
                if(book.CustomerId==currentCustomer.CustomerId)
                {
                   if(book.BookingId==bookId)
                   {
                       if(book.BookingStatus==Status.Booked || book.BookingStatus==Status.Initiated
                        )
                    {
                        currentCustomer.WalletAmount+=book.TotalPrice;
                        System.Console.WriteLine("Booking cancelled successfully");
                        book.BookingStatus=Status.Cancelled;
                        
                        flag=1;
                    }
                    flag=2;
                   }
                    
                }
            }
            if(flag==2)
            {
                System.Console.WriteLine("Booking already cancelled");
            }
            
            
         }

         public static void ShowHistory()
         {
            foreach (BookingDetails book in bookingList)
            {
                if(book.CustomerId==currentCustomer.CustomerId)
                {
                    System.Console.WriteLine($"Booking Id:{book.BookingId} Customer Id:{book.CustomerId} Total price:{book.TotalPrice} DateOfBooking:{book.DateBooked} Booking Status:{book.BookingStatus}");
                }
            }
         }
         
        public static void ShowOrder()
        {
            foreach (BookingDetails book in bookingList)
            {
                foreach (OrderDetails order in orderList)
                {
                   if(book.CustomerId==currentCustomer.CustomerId)
                   {
                       if(book.BookingId==order.BookingId)
                        {
                            System.Console.WriteLine($"Order Id:{order.OrderId}  BookingId:{order.BookingId} FoodId:{order.FoodId} Purchase count:{order.PurchaseCount} Total price:{order.PriceofOrder}");
                        
                        }
                   }
                
                }
            }
        }
    }


}
