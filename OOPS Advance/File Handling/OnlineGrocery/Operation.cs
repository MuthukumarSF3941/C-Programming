using System;



namespace OnlineGrocery
{
    public delegate void EventManager();
    public static class Operation
    {

     public static List<CustomerDetails>  customerList=new List<CustomerDetails>();

     public static List<ProductDetails>  ProductList=new List<ProductDetails>();

     public static List<OrderDetails>  orderList=new List<OrderDetails>();

     public static List<BookingClass>  bookinglist=new List<BookingClass>(); 

     static CustomerDetails currentLoggedInCustomer=null;

     public static  event EventManager eventLink=null;

     public static void Subscribe()
     {
        eventLink+=new EventManager(Files.CreateFile);
        eventLink+=new EventManager(Files.ReadFiles);
        eventLink+=new EventManager(Operation.MainMenu);
        eventLink+=new EventManager(Files.WriteFiles);
     }

     public static void StartEvent()
     {
        Subscribe();
        eventLink();
     }
       

public static void MainMenu()
{
    string option="yes";
    do
    {
        //content
       int choice;
       System.Console.WriteLine("-------------Main Menu---------------");
       System.Console.WriteLine("Enter Your Choice\n 1.Customer Registration\n 2.Customer LogIn\n 3.Exit");
    
        choice=int.Parse(Console.ReadLine());
        switch (choice)
       {
            case 1:
            {
              CustomerRegistration();
              break;
            }
            case 2:
            {
              CustomerLogIn();
               break;
            }
            case 3:
            {
               option="no";
               System.Console.WriteLine("You are Exiting Main Menu");
               break;
            }
             default:
             System.Console.WriteLine("Invalid Entry");
             break;
        }
    
     
      
    }while (option=="yes");

       
} 

static void CustomerRegistration()
    {
       System.Console.WriteLine("Customer Registration method Called");

       System.Console.WriteLine("Enter your Name");
       string name=Console.ReadLine();

       System.Console.WriteLine("Enter ypur Father name");
       string fatherName=Console.ReadLine();
       
       System.Console.WriteLine("Enter your gender");
       Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);

       System.Console.WriteLine("Entyer Mobile Number");
       long mobile=long.Parse(Console.ReadLine());

       System.Console.WriteLine("Enter your Date of Birth in dd/MM/yyyy Format");
       DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);

       System.Console.WriteLine("Enter your Mail Id ");
       string mail=Console.ReadLine();
       
       CustomerDetails customer10=new CustomerDetails(name,fatherName,gender,mobile,dob,mail,0);
       customerList.Add(customer10);
       
       
       System.Console.WriteLine($"Customer Id:{customer10.CustomerId}");
       
    }

static void CustomerLogIn()
    {
        System.Console.WriteLine("Customer Log-In method Called");

        System.Console.WriteLine("Enter your Customer Id");
        string loginId=Console.ReadLine().ToUpper();
        int flag=0;

          foreach (CustomerDetails customer in customerList)
                {
                   if(customer.CustomerId==loginId)
                   {
                     System.Console.WriteLine("Login Successful");
                     flag++;
                     currentLoggedInCustomer=customer;
                     SubMenu();
                   }

                }
                if(flag==0)
                {
                    System.Console.WriteLine("Invalid Customer ID");
                }


    
    }
  
public static void SubMenu()
    {
        string option="yes";
        do
        {
            int choice;
            System.Console.WriteLine("Enter your choice\n 1.show Customer Details\n 2.Show Product Details\n 3.Wallet Recharge\n 4.Take Order\n 5.Modify Order\n 6.Cancel Order\n 7.Exit sub Menu");
            choice=int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                {
                    System.Console.WriteLine("Show customer Details");
                    currentLoggedInCustomer.ShowCustomerDetails();
                    break;
                }

                case 2:
                {
                    System.Console.WriteLine("Show product Details");
                    ShowProducts();
                    break;
                }
                case 3:
                {
                    System.Console.WriteLine("wallet Recharge");
                    currentLoggedInCustomer.WalletRecharge();
                    break;
                }
                case 4:
                {
                    System.Console.WriteLine("Take order");
                    TakeOrder();
                    break;
                }
                case 5:
                {
                    System.Console.WriteLine("Modify order");
                    ModifyOrder();
                    break;
                }
                case 6:
                {
                    System.Console.WriteLine("cancel Order");
                    CancelOrder();
                    break;
                }
                case 7:
                {
                    System.Console.WriteLine("Exiting sub menu");
                    option="no";
                    break;
                }
                default:
                    break;
            }
            
            
          
            

        } while (option=="yes");
    }
                  
public static void DefaultValues()
    {
               //Customer Details Data
                CustomerDetails customer1=new CustomerDetails("Ravi","Ettapparajan",Gender.Male,974774646,new DateTime(1999,11,11),"ravi@gmail.com",0);
                CustomerDetails customer2=new CustomerDetails("Baskaran","Sethurajan",Gender.Male,847575775,new DateTime(1999,11,11),"baskaran@gmail.com",0);

                customerList.Add(customer1); 
                customerList.Add(customer2);

              

                //Product Details data
                ProductDetails product1=new ProductDetails("Sugar",20,40);
                ProductDetails product2=new ProductDetails("Rice",	100,	50);
                ProductDetails product3=new ProductDetails("Milk",10,40);
                ProductDetails product4=new ProductDetails("Coffee",10,10);
                ProductDetails product5=new ProductDetails("Tea",10,10);
                ProductDetails product6=new ProductDetails("Masala Powder"	,10	,20);
                ProductDetails product7=new ProductDetails("Salt",10,10);
                ProductDetails product8=new ProductDetails("Turmeric Powder",10,25);
                ProductDetails product9=new ProductDetails("Chilli Powder",10,20);
                ProductDetails product10=new ProductDetails("Groundnut Oil",10,140);

                ProductList.Add(product1);
                ProductList.Add(product2);
                ProductList.Add(product3);
                ProductList.Add(product4);
                ProductList.Add(product5);
                ProductList.Add(product6);
                ProductList.Add(product7);
                ProductList.Add(product8);
                ProductList.Add(product9);
                ProductList.Add(product10);

                //Order Detaild data

                OrderDetails order1=new OrderDetails(	"BID3001","PID101",2,80);
                OrderDetails order2=new OrderDetails(	"BID3001","PID102",	2	,100);
                OrderDetails order3=new OrderDetails(	"BID3001","PID103",1,40);
                OrderDetails order4=new OrderDetails(	"BID3002","PID101",1,40);
                OrderDetails order5=new OrderDetails(	"BID3002","PID102",4,200);

                orderList.Add(order1);
                orderList.Add(order2);
                orderList.Add(order3);
                orderList.Add(order5);
                orderList.Add(order5);


                //Booking Detail Data

                BookingClass book1=new BookingClass("CID3001",220,new DateTime(2012,12,10),status.Booked);
                BookingClass book2=new BookingClass("CID3002",400,new DateTime(2022,10,11),status.Booked);
                BookingClass book3=new BookingClass("CID3001",280,new DateTime(2021,10,11),status.Cancelled);

                bookinglist.Add(book1);
                bookinglist.Add(book2);
                bookinglist.Add(book3);

    }              
  
public static void ShowProducts()
     {
        foreach(ProductDetails product in ProductList)
        {
            product.ShowProductDetails();
        }
     } 

public static void TakeOrder()
{
    System.Console.WriteLine("Calling Take Order");

    string choice="";

    //create booking object
    BookingClass book1=new BookingClass(currentLoggedInCustomer.CustomerId,0,DateTime.Now,status.Initiated);

    //create local list
    List<OrderDetails> TempOrderList=new List<OrderDetails>();

    string option="yes";
    double totalPrice=0;
   do
   {
         //show product list
          ShowProducts();

          //get product Id
          System.Console.WriteLine("Enter the product id to buy");
          string productId=Console.ReadLine().ToUpper();

          int flag=0;
         

           //check is it a valid product Id
            foreach(ProductDetails product in ProductList)
           { 
                if(productId==product.ProductId)
                {
                    flag++;
                   //ask quantity
                   System.Console.WriteLine("Enter Quantity");
                   int productQuantity=int.Parse(Console.ReadLine());
                   

                       //compare the quantity
                      if (productQuantity<=product.AvailableQuantity)
                      {
                          //calculate price;
                          double totalAmount=productQuantity*product.Price;
                          
                          


                          //create object & add it to the local list
                           OrderDetails tempOrder=new OrderDetails(book1.BookingId,productId,productQuantity,totalAmount);
                           TempOrderList.Add(tempOrder);

                           System.Console.WriteLine($" Order is placed\n Order ID is:{tempOrder.OrderId}");
                           product.AvailableQuantity-=productQuantity;



                        }
                        else
                        {
                            System.Console.WriteLine("Quantity not available");
                        }
                }
                
            }

            if (flag==0)
            {
                System.Console.WriteLine("Invalid Product Id");
            }

        System.Console.WriteLine("Do you want to continue the order");
        option=Console.ReadLine().ToLower();
        
    } while (option=="yes");

    foreach(OrderDetails order in TempOrderList)
    {
        totalPrice+=order.OrderPrice;
    }

    System.Console.WriteLine("do you want to confirm the order");
    choice=Console.ReadLine().ToLower();

    while (choice=="yes")
    {
        if(totalPrice<=currentLoggedInCustomer.WalletBalance)
        {
            book1.TotalPrice=totalPrice;
            book1.BookingStatus=status.Booked;
            currentLoggedInCustomer.WalletBalance-=totalPrice;
            bookinglist.Add(book1);
            orderList.AddRange(TempOrderList);
           
            System.Console.WriteLine("Booking successful");
            System.Console.WriteLine("Booking Id:"+book1.BookingId);
             break;
        }
        else
        {
           System.Console.WriteLine("Insufficient Balance\n please Recharge your Wallet");
           System.Console.WriteLine("Total Amount="+totalPrice);
           currentLoggedInCustomer.WalletRecharge();
           choice="yes";
           
        }
        
    }
    if(choice=="no")
    {
        System.Console.WriteLine("Your Order is not confirmed");
        foreach (ProductDetails product in ProductList)
        {
            foreach (OrderDetails order in TempOrderList)
            {
                 if(product.ProductId==order.ProductId)
                 {
                    product.AvailableQuantity+=order.ProductCount;
                 }
           
            }
           
        }
    }
    

       
       
}

public static void ModifyOrder()
     {
         System.Console.WriteLine("Calling Modify order");
     }

public static void CancelOrder()
     {
        System.Console.WriteLine("calling cancel order");
        ShowBookingHistory();
        System.Console.WriteLine("Enter Booking Id to cancel the order");
        string bookId=Console.ReadLine().ToUpper();
        int flag=0;
        

        foreach (BookingClass book in bookinglist)
        {
            if(book.BookingId==bookId && book.BookingStatus==status.Booked)
            {
                flag++;
                foreach (OrderDetails order in orderList)
                {
                    if(book.BookingId==order.BookingId)
                    {
                        foreach (ProductDetails product in ProductList)
                        {
                            if(order.ProductId==product.ProductId)
                            {
                                product.AvailableQuantity+=order.ProductCount;
                                System.Console.WriteLine("Order cancelled sucessfully");
                                currentLoggedInCustomer.WalletBalance+=book.TotalPrice;
                                book.BookingStatus=status.Cancelled;
                            }
                        }
                    }
                }
            }
            
        }
        if(flag==0)
        {
            System.Console.WriteLine("Invalid booking Id");
        }

     }


public static void ShowBookingHistory()
{
    foreach (BookingClass book in bookinglist)
    {
        if(book.CustomerId==currentLoggedInCustomer.CustomerId)
        {
            if(book.BookingStatus==status.Booked)
            {
                book.ShowBooking();
            }
        }
    }
}

    }
}