
using System;
namespace OnlineTheaterTicketBooking
{
    //delegate initializing
    public delegate void EventManager();
    public static class Operation
    {
   
         //craeting eventlink
        public static event EventManager eventlink=null;
        
        //ordering tha operations using method
        public static void Subscribe()
        {
            eventlink+=new EventManager(Files.CreateFiles);
            eventlink+=new EventManager(Files.ReadFiles);
            eventlink+=new EventManager(Operation.MainMenu);
            eventlink+=new EventManager(Files.WriteFiles);
        }
          
        //trigger the event to happen
        public static void StartEvent()
        {
            Subscribe();
            eventlink();
        }
    

        //creating user list
        public static List<UserDetails> userList=new List<UserDetails>();

         //creating Booking list
        public static List<BookingDetails> bookingList=new List<BookingDetails>();

        //creating Theater list
        public static List<TheaterDetails> TheaterList=new List<TheaterDetails>();

        //creating Movie list
        public static List<MovieDetails> movieList=new List<MovieDetails>();

         //creating Screening list
        public static List<ScreeningDetatils> screeningList=new List<ScreeningDetatils>();

        //temporary object to capture the logged in customers data
        static UserDetails currentLoggedUser=null;

        static string tempTheateId="";
        static bool temp=true;
        public static void MainMenu()
        {
           
        string option="yes";
            do
            {
               

                System.Console.WriteLine("------------Main Menu-----------");
                int choice;
                System.Console.WriteLine("Enter Your Option\n 1.User Registration\n 2.Log In\n 3.Exit");
                choice=int.Parse(Console.ReadLine());

               switch (choice)
               {
                  case 1:
                  {
                    System.Console.WriteLine("You selected Registration");
                    Registration();
                    break;
                  }

                  case 2:
                  {
                    System.Console.WriteLine("You selected LogIn");
                    LogIn();
                    break;
                  }

                  case 3:
                  {
                    System.Console.WriteLine("Thank You!");
                    option="no";
                    break;
                  }



                  default:
                  System.Console.WriteLine("Invalid Entry");
                  break;
                }
                
                
            } while (option=="yes");
            
        }
        
        //method to store default values
        public static void DefaultValues()
        {

            //user details  data
            UserDetails user1=new UserDetails("Ravichandran",30,8599488003,1000);
            UserDetails user2=new UserDetails("Baskaran",30,9857747327,2000);


             // adding user details data into list
            userList.Add(user1);
            userList.Add(user2);
  
            //Booking details  data  
            BookingDetails book1=new BookingDetails("UID1001","MID501","TID301",1,200,Status.Booked);
            BookingDetails book2=new BookingDetails("UID1001","MID504","TID302",1,400,Status.Booked);
            BookingDetails book3=new BookingDetails("UID1002","MID505","TID302",1,300,Status.Booked);


            // adding Booking details data into list
            bookingList.Add(book1);
            bookingList.Add(book2);
            bookingList.Add(book3);


            //Theater details  data
            TheaterDetails theater1=new TheaterDetails("Inox","Anna Nagar");
            TheaterDetails theater2=new TheaterDetails("Ega Theatre","Chetpet");
            TheaterDetails theater3=new TheaterDetails("Kamala","Vadapalani");


            // adding Theater details data into list
            TheaterList.Add(theater1);
            TheaterList.Add(theater2);
            TheaterList.Add(theater3);
   

            //Movie details  data
            MovieDetails movie1=new MovieDetails("MID501","Bagubali 2","Telugu");
            MovieDetails movie2=new MovieDetails("MID502","Ponniyin Selvan","Tamil");
            MovieDetails movie3=new MovieDetails("MID503","Cobra","Tamil");
            MovieDetails movie4=new MovieDetails("MID504","Vikram","Hindi (Dubbed)");
            MovieDetails movie5=new MovieDetails("MID505","Vikram","Tamil");
            MovieDetails movie6=new MovieDetails("MID506","Beast","English");


            // adding Movie details data into list
            movieList.Add(movie1);
            movieList.Add(movie2);
            movieList.Add(movie3);
            movieList.Add(movie4);
            movieList.Add(movie5);
            movieList.Add(movie6);


            //Screening details  data
            ScreeningDetatils screen1=new ScreeningDetatils("MID501","TID301",5,200);
            ScreeningDetatils screen2=new ScreeningDetatils("MID502","TID301",2,300);
            ScreeningDetatils screen3=new ScreeningDetatils("MID506","TID301",1,50);
            ScreeningDetatils screen4=new ScreeningDetatils("MID501","TID302",11,400);
            ScreeningDetatils screen5=new ScreeningDetatils("MID502","TID302",20,300);
            ScreeningDetatils screen6=new ScreeningDetatils("MID504","TID302",2,500);
            ScreeningDetatils screen7=new ScreeningDetatils("MID505","TID303",11,100);
            ScreeningDetatils screen8=new ScreeningDetatils("MID502","TID303",20,200);
            ScreeningDetatils screen9=new ScreeningDetatils("MID504","TID303",2,350);


            // adding Screening details data into list
            screeningList.Add(screen1);
            screeningList.Add(screen2);
            screeningList.Add(screen3);
            screeningList.Add(screen4);
            screeningList.Add(screen5);
            screeningList.Add(screen6);
            screeningList.Add(screen7);
            screeningList.Add(screen8);
            screeningList.Add(screen9);



          

        }

        //creating Registration method
        public static void Registration()
        {
           System.Console.WriteLine("------------Registration-----------");

           System.Console.WriteLine("Enter Your Name");
           string name=Console.ReadLine();
           
           System.Console.WriteLine("Enter your age");
           int age=int.Parse(Console.ReadLine());

           System.Console.WriteLine("Enter Your Phone Number");
           long phoneNumber=long.Parse(Console.ReadLine());

           System.Console.WriteLine("Enter Wallet Amount");
           double Wallet=double.Parse(Console.ReadLine());

           UserDetails user5=new UserDetails(name,age,phoneNumber,Wallet);
           userList.Add(user5);
           System.Console.WriteLine("Registration Completed");
           System.Console.WriteLine("Your User Id is:"+user5.UserId);
        } 

        //creating LogIn method
        public static void LogIn()
        {
            System.Console.WriteLine("----------LOG In PAGE--------");
            int flag=0;
            System.Console.WriteLine("Enter your User ID");
            string userId=Console.ReadLine().ToUpper();

            foreach (UserDetails user in userList)
            {
                if(userId==user.UserId)
                {
                    flag++;
                    currentLoggedUser=user;
                    System.Console.WriteLine("Log In SuccessFull");
                    SubMenu();
                }
            }
            if(flag==0)
            {
                System.Console.WriteLine("Invalid User ID");
            }
            
        }   
    
        //creating submenu method
        public static void SubMenu()
        {
            string option="yes";
            do
            {
                int choice;
                System.Console.WriteLine("------------Sub Menu------------");

                System.Console.WriteLine("Enter your Option\n 1.Ticket Booking\n 2.Ticket Cancellation\n 3.Booking History\n 4.Wallet Recharge\n 5.Exit");
                choice=int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                    {
                        System.Console.WriteLine("You enter ticket booking");
                        TicketBooking();
                         break;
                    }

                    case 2:
                    {
                        System.Console.WriteLine("You enter ticket cancellation");
                        TicketCancel();
                         break;
                    }

                    case 3:
                    {
                        System.Console.WriteLine("you entered show booking History");
                        BookingHistory();
                         break;
                    }

                    case 4:
                    {
                        System.Console.WriteLine("---------WALLET RECHARGE----------");
                        System.Console.WriteLine("Enter amount to recharge");
                        double amount=double.Parse(Console.ReadLine());

                        currentLoggedUser.WalletRecharge(amount);

                         break;
                    }

                    case 5:
                    {
                        System.Console.WriteLine("You enter Exit sub Menu");
                        option="no";
                         break;
                    }
                    default:
                        break;
                }
                
                
            } while (option=="yes");

            
        }
    
        //method to book a ticket to the user    
        public static void TicketBooking()
        {    
            System.Console.WriteLine("-----------Ticket Booking-----------");
            int flag=0; 
            

             //Show theater Details
              ShowTheater();

              /*ask theater ID:
              and show tha available movies in tha theater*/

              ShowMovie();
            if(temp==true)
            {
                System.Console.WriteLine("enter Movie Id");
                string movieId=Console.ReadLine().ToUpper();

               foreach (ScreeningDetatils screen in screeningList)
               {
                  if(tempTheateId==screen.TheaterId)
                  {
                    if(screen.MovieId==movieId)
                    {
                      flag++;
                      System.Console.WriteLine("Enter seat count");
                      int count=int.Parse(Console.ReadLine());

                       if(screen.SeatsAvailable>=count)
                       {
                          double Ticketamount=screen.TicketPrice*count;

                          double TotalAmount=(Ticketamount*0.18)+Ticketamount;

                          if(currentLoggedUser.WalletBalance>=TotalAmount)
                          {
                              
                              BookingDetails book=new BookingDetails(currentLoggedUser.UserId,movieId,tempTheateId,count,TotalAmount,Status.Booked);
                              bookingList.Add(book);
                              System.Console.WriteLine("Booking conformed");
                              System.Console.WriteLine("Booking ID is:"+book.BookingId);
                              currentLoggedUser.WalletBalance-=TotalAmount;
                              screen.SeatsAvailable-=count;
                          }
                          else
                          {
                             System.Console.WriteLine("Insufficient Balance\n Please Recharge your wallet");
                          }

                        }
                        else
                        {
                             System.Console.WriteLine($"Required seats not Available\n The available seat is:{screen.SeatsAvailable}");
                        }
                    }
                  }
                }
                if(flag==0)
                {
                  System.Console.WriteLine("Invalid movie Id");
                  
                }
            }
              

             
              
        }
        
        //Method to cancel the booking of the user
        public static void TicketCancel()
        {
            System.Console.WriteLine("-----------Cancel Ticket----------");
            int flag=0;
            BookingHistory();
           
           //ask booking Id from user
           System.Console.WriteLine("Enter booking Id To cancel");
           string bookid=Console.ReadLine().ToUpper();

           foreach (BookingDetails book in bookingList)
           {
              if(currentLoggedUser.UserId==book.UserId)
              {
                
                if(book.BookingId==bookid)
                {
                    flag++;
                    
                    if(book.BookingStatus==Status.Booked)
                    {
                        System.Console.WriteLine("Booking Cancelled");
                        book.BookingStatus=Status.Cancelled;
                        currentLoggedUser.WalletBalance+=book.TotalAmount;

                        foreach (ScreeningDetatils screen in screeningList)
                        {
                            if(book.TheaterId==screen.TheaterId)
                            {
                                if(book.MovieId==screen.MovieId)
                                {
                                    screen.SeatsAvailable+=book.SeatCount;
                                }
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
           if(flag==0)
           {
            System.Console.WriteLine("Wrong Booking Id");
           }
           
           
        }
     
        //Method to show Booking History of the Customer
        public static void BookingHistory()
        {
            //show the booking history of the user 
               System.Console.WriteLine("Booking Id\t  UesrId\t Movie ID      TheaterID SeatCount TotalAmount Booking Status");
               foreach (BookingDetails book in bookingList)
               {
                    if(currentLoggedUser.UserId==book.UserId)
                    {
                       System.Console.WriteLine($"{book.BookingId}\t\t {book.UserId}\t {book.MovieId}\t\t {book.TheaterId}\t {book.SeatCount}\t\t {book.TotalAmount}\t {book.BookingStatus}");
                    }
                }
        }


        //method to show theater details
        public static void ShowTheater()
        {
            //showing Theater Details
            System.Console.WriteLine("Theater ID\t  Theater Name\t \tTheater Location");
            foreach (TheaterDetails theater in TheaterList)
            {
                System.Console.WriteLine($"{theater.TheaterId}\t\t  {theater.TheaterName}\t\t {theater.TheaterLocation}");
            }
        }
    
        //method to show available movies in particular theaters
        public static void ShowMovie()
        {

            int flag=0;
             // showing the available movies in a particular Theater
             System.Console.WriteLine("Enter the theater Id");
              string theaterId=Console.ReadLine().ToUpper();
              tempTheateId=theaterId;
              
             foreach (ScreeningDetatils screen in screeningList)
              {
                if(theaterId==screen.TheaterId)
                { 
                    temp=true;
                    flag++;
                      
                      foreach (MovieDetails movie in movieList)
                      {
                          if(screen.MovieId==movie.MovieId)
                          {
                            
                            System.Console.WriteLine($"MovieID:{movie.MovieId}\t\t Movie Name:{movie.MovieName}\t Language:{movie.Language}");
                            
                          }
                      }
                }
              }

              if(flag==0)
              {
                temp=false;
                System.Console.WriteLine("Invalid theater Id");
                
              }
        }
    
    
    
    }
}
