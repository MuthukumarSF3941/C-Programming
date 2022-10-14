using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedical
{
    public static class Operation
    {
          public static List<UserDetails> userList=new List<UserDetails>();

          public static List<MedicineDetails> medicineList=new List<MedicineDetails>();

          public static List<OrderDetails> orderList=new List<OrderDetails>();

           static UserDetails currentUser=null;

          public static void MainMenu()
          {
            int choice;

            do
            {
                System.Console.WriteLine("Enter your choice\n 1.Registraion\n  2.LogIn\n 3.Order History\n 4.Exit ");
                choice=int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                    {
                        System.Console.WriteLine("Registration");
                        Registraion();
                        break;
                    }
                     case 2:
                    {
                        System.Console.WriteLine("login");
                        LogIn();
                        break;
                    }
                     case 3:
                    {
                        System.Console.WriteLine("Show History");
                        foreach (OrderDetails order in orderList)
                        {
                            System.Console.WriteLine($"Order Id:{order.OrderId} User Id:{order.UserId} Medicine ID:{order.MedicineId} Medicine count=:{order.MedicineCount} total price:{order.TotalPrice} oredr date:{order.OrderDate.ToShortDateString()} order status:{order.OrderStatus} ");
                        }
                        break;
                    }
                     case 4:
                    {
                        System.Console.WriteLine("Exit");
                        break;
                    }
                        
                    default:
                    System.Console.WriteLine("Invalid Entry");
                        break;
                }
                
                
            } while (choice!=4);
          }

          public static void Registraion()
          {

            System.Console.WriteLine("Enter ypur name");
            string name=Console.ReadLine();
            

            System.Console.WriteLine("Enter your age");
            int age=int.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter your city");
            string city=Console.ReadLine();
            
            System.Console.WriteLine("Enter mobile number");
            long mobile=long.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter wallet amount");
            double wallet=double.Parse(Console.ReadLine());

            UserDetails user2=new UserDetails(name,age,city,mobile,wallet);
            userList.Add(user2);

            System.Console.WriteLine("Your userId is"+user2.UserId);

          }
        
        public static void LogIn()
        {
            System.Console.WriteLine("Enter your userID");
            string userId=Console.ReadLine().ToUpper();
            int flag=0;
            
            foreach (UserDetails user in userList)
            {
                if(userId==user.UserId)
                {
                     System.Console.WriteLine("Log in successful");
                     flag++;
                     currentUser=user;
                     SubMenu();
                }
              
            }
            if(flag==0)
            {
                System.Console.WriteLine("wrong user Id");
            }
        }
        
        public static void SubMenu()
        {
            int choice;

            do
            {
                 System.Console.WriteLine("Enter your choice\n 1.Show mediicine Details\n 2.Purchase Medicine\n 3.Cancel purchase\n 4.show purchase History\n 5.Recharge\n 6.Exit ");
                choice=int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                    {
                        System.Console.WriteLine("Medicine details");
                        MedicineDetail();
                         break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("Purchase");
                        PurchaseMedicine();
                         break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("Cancel Purchase");
                        CancelPurcahse();
                         break;
                    }
                    case 4:
                    {
                        System.Console.WriteLine("Purchase History");
                        ShowHistory();
                         break;
                    }
                    case 5:
                    {
                        System.Console.WriteLine("Recharge");
                        Recharge();
                        break;
                    }
                    case 6:
                    {
                        System.Console.WriteLine("Exit");
                         break;
                    }
                    
                    default:
                    System.Console.WriteLine("invalid Entry");
                        break;
                }
                
                 
            } while (choice!=6);

          
        }

        public static void MedicineDetail()
        {
            System.Console.WriteLine("Medicine ID   Medicine Name    Available Date Of Expiry");
            foreach (MedicineDetails item in medicineList)
            {
                System.Console.WriteLine($" {item.MedicineId}            {item.MedicineName}    {item.AvailbleCount}  {item.DateOfExpiry.ToShortDateString()}");
            }
        }
        
        public static void PurchaseMedicine()
        {
            MedicineDetail();
            System.Console.WriteLine("Enter the medicin Id to purchase");
            string medId=Console.ReadLine().ToUpper();
            foreach (MedicineDetails med in medicineList)
            {
                if(medId==med.MedicineId)
                {
                    System.Console.WriteLine("Enter the count you want to buy");
                    int count=int.Parse(Console.ReadLine());
                    if(count<=med.AvailbleCount)
                    {
                        double amount=(double)count*med.Price;
                        if(amount<=currentUser.Balance)
                        {
                            if(DateTime.Now<med.DateOfExpiry)
                            {
                                med.AvailbleCount-=count;
                                currentUser.Balance-=amount;
                                OrderDetails order2=new OrderDetails(currentUser.UserId,med.MedicineId,count,DateTime.Now,amount,Status.Purchased);
                                orderList.Add(order2);

                               System.Console.WriteLine($"Order taken order Id is:{order2.OrderId}");
                            }
                        }
                    }
                }
            }
            

        }

        public static void CancelPurcahse()
        {
            ShowHistory();

            System.Console.WriteLine("Enter order Id to cancel");
            string ordID=Console.ReadLine().ToUpper();
            foreach(OrderDetails order in orderList)
            {
                if(order.OrderId==ordID)
                {
                    
                if(order.UserId==currentUser.UserId)
                {
                    if(order.OrderStatus==Status.Purchased)
                    {
                        foreach(MedicineDetails medicine in medicineList) 
                        {
                            if(medicine.MedicineId==order.MedicineId)
                            {
                                medicine.AvailbleCount+=order.MedicineCount;
                                currentUser.Balance+=order.TotalPrice;
                                System.Console.WriteLine("Order cancelled");
                                order.OrderStatus=Status.Cancelled;
                            }
                        }  
                    }
                    else
                    {
                       System.Console.WriteLine("Already cancelled");
                    }
                }
                }
            }
        }

        public static void ShowHistory()
        {
            foreach(OrderDetails order in orderList)
            {
                if(currentUser.UserId==order.UserId)
                {
                    System.Console.WriteLine($"Order Id:{order.OrderId} User Id:{order.UserId} Medicine ID:{order.MedicineId} Medicine count=:{order.MedicineCount} total price:{order.TotalPrice} oredr date:{order.OrderDate.ToShortDateString()} order status:{order.OrderStatus} ");
                }
            }

        }

        public static void Recharge()
        {
            System.Console.WriteLine("Enter amount to recharge");

            double amount=double.Parse(Console.ReadLine());
            currentUser.Balance+=amount;
            System.Console.WriteLine("tOTAL BALANCE =:"+currentUser.Balance);
        }



    }
}