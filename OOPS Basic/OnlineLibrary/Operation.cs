using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLibrary
{
    public static class Operation
    {
        static List<UserDetails> userList=new List<UserDetails>();

        static List<BookDetails> bookList=new List<BookDetails>();

        static List<BorrowDetails> borrowList=new List<BorrowDetails>();

         static UserDetails currentUser=null;

         public static void MainMenu()
         {
            int choice;

            do
            {
                System.Console.WriteLine("Enter Your Choice\n 1.Registration\n 2.User Login\n 3.Exit");
                choice=int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                    {
                        System.Console.WriteLine("Registration");
                        Regitrstion();

                         break;
                    }
                     case 2:
                    {
                        System.Console.WriteLine("LogIn");
                        UserLogin();
                         break;
                    }
                     case 3:
                    {
                        System.Console.WriteLine("Exit");
                         break;
                    }
                
                    default:
                    System.Console.WriteLine("Invalid Entry");
                        break;
                }
                
                
            } while (choice!=3);
         }
         

         public static void Regitrstion()
         {
            System.Console.WriteLine("Enter Youer Name");
            string name=Console.ReadLine();
            
            System.Console.WriteLine("Enter Your Gender");
            Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);

            System.Console.WriteLine("Enter your Department");
            Department dept=Enum.Parse<Department>(Console.ReadLine(),true);

            System.Console.WriteLine("Enter Your Mobile Number");
            long mobile=long.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter Your Mail Id");
            string mail=Console.ReadLine();

            System.Console.WriteLine("Enter Wallet Recharge");
            int walletAmount=int.Parse(Console.ReadLine());
            
            UserDetails user1=new UserDetails(name,gender,dept,mobile,mail,walletAmount);
            userList.Add(user1);

            System.Console.WriteLine($"Your UseId is:{user1.UserId}");
         } 
         
         public static void UserLogin()
         {
            System.Console.WriteLine("Enter your User Id");
            string userId=Console.ReadLine().ToUpper();

            foreach (UserDetails user in userList)
            {
                if (userId==user.UserId)
                {
                    System.Console.WriteLine("Log in Successfull");
                    currentUser=user;
                    SubMenu();
                }
            }
        
         }

         public static void SubMenu()
         {
            int choice;

            do
            {
               System.Console.WriteLine("Enter Your Choice\n   1.Borrow Book\n  2.Return Books\n 3.Show Borrowed History\n 4.Wallet Recharge\t 5.Exit subMenu"); 
               choice=int.Parse(Console.ReadLine());

               switch (choice)
               {
                case 1:
                {
                    System.Console.WriteLine("Borrow Book");
                    borrowBook();
                      break;
                }
                case 2:
                {
                     System.Console.WriteLine("Return Books");
                    returnBook();
                      break;
                }
                case 3:
                {
                    System.Console.WriteLine("Show Borrowed History");
                    showHistory();
                      break;
                }
                case 4:
               {
                System.Console.WriteLine("Wallet Recharge");
                WalletAmount();
                break;
               }
                case 5:
                {
                    System.Console.WriteLine("Exit SubMenu");
                      break;
                }
                default:
                    break;
               }
               
            } while (choice!=5);
         }
         
         public static void borrowBook()
         {
            ShowBooks();
            int count=0;
            System.Console.WriteLine("Enter Book Id");
            string bookId=Console.ReadLine().ToUpper();
            
            foreach (BookDetails book in bookList)
            {

                if(book.BookId==bookId)
                {
                  if(book.BookCount>1)
                {
                    foreach (BorrowDetails borrow in borrowList)
                    {
                        if(currentUser.UserId==borrow.UserId && borrow.BookStatus==Status.Issued)
                        {
                            count++;
                        }  
                    }
                    if(count<3)
                    {
                        BorrowDetails borrow1=new BorrowDetails(bookId,currentUser.UserId,DateTime.Now,Status.Issued);
                        borrowList.Add(borrow1);
                        book.BookCount--;
                        System.Console.WriteLine($"Borrow id is:{borrow1.BorrowId}");
                    }
                    else
                    {
                       System.Console.WriteLine("You are already taken maximun number of books");
                    }
                }
                else{
                    System.Console.WriteLine("Book Not available");
                    foreach (BorrowDetails borrow in borrowList)
                    {
                        if(book.BookId==borrow.BookId)
                        {
                            if(borrow.BookStatus==Status.Issued)
                            {
                                System.Console.WriteLine($"Next Available date of book is:{borrow.BorrowDate.AddDays(15)}");
                            }
                        }
                    }
                }
                }
            }
            
         }
         public static void ShowBooks()
         {
            foreach (BookDetails book in bookList)
            {
                System.Console.WriteLine($"Book Id :{book.BookId}\t Book Name:{book.BookName} Book Name:{book.AuthorName}\t Book Count:{book.BookCount}");
            }
         }
         
        public static void returnBook()
        {
            
               foreach (BorrowDetails borrow in borrowList)
           {
                if(currentUser.UserId==borrow.UserId)
                {
                     TimeSpan one=DateTime.Now-borrow.BorrowDate.AddDays(15);
                     int a=one.Days;
                 if(a>0)
                    {
                         System.Console.WriteLine($"Borrow Id:{borrow.BorrowId}\t Book Id:{borrow.BookId}\t Borrow Date:{borrow.BorrowDate} Return Date;{borrow.BorrowDate.AddDays(15) }\t Charge={a*1}");
                         System.Console.WriteLine("Do you want to return the book");
                         string option=Console.ReadLine().ToLower();
                         if(option=="yes")
                       {
                            System.Console.WriteLine("Enter Borrow ID");
                            string bId=Console.ReadLine().ToUpper();
                            if (borrow.BorrowId==bId)
                            {
                               if(borrow.BookStatus==Status.Issued)
                               {
                                 
                                foreach (BookDetails book in bookList)
                                {
                                    if(borrow.BookId==book.BookId)
                                    {
                                      if(a<currentUser.WalletAmount)
                                      {
                                          System.Console.WriteLine("Book Returned scuccefully");
                                        book.BookCount++;
                                        borrow.BookStatus=Status.Returned;
                                        currentUser.WalletAmount-=a;
                                      }
                                      else
                                      {
                                         System.Console.WriteLine("Insufficient balance Please Recharge");
                                      }
                                    }
                                }
                                }
                             
                               else
                               {
                                System.Console.WriteLine("Book already Returned");
                               }
                            }
                            
                        }
                         
                    }
                    else
                    {
                        a=0;
                        System.Console.WriteLine($"Borrow Id:{borrow.BorrowId}\t Book Id{borrow.BookId}\t Borrow Date:{borrow.BorrowDate} Return Date;{borrow.BorrowDate.AddDays(15) }\t Charge={a*1}");
                        
                         System.Console.WriteLine("Do you want to return the book");
                         string option=Console.ReadLine().ToLower();

                     if(option=="yes")
                       {
                            System.Console.WriteLine("Enter Borrow Id");
                            string bId=Console.ReadLine().ToUpper();
                            if(borrow.BookId==bId)
                            {
                                if(borrow.BookStatus==Status.Issued)
                                {
                                    System.Console.WriteLine("Book Returned Sucessfully");
                                    foreach(BookDetails book in bookList)
                                    {
                                        if(borrow.BookId==book.BookId)
                                        {
                                            book.BookCount++;
                                            borrow.BookStatus=Status.Returned;
                                        }
                                    }
                                }
                                else
                                {
                                    System.Console.WriteLine("Booke Already Returned");
                                }
                            }
                            
                        }


                         
                    }

                    
                }
            }
        }

        public static void showHistory()
        {
            foreach (BorrowDetails borrow in borrowList)
            {
                if (borrow.UserId==currentUser.UserId)
                {
                    System.Console.WriteLine($"Borrow Id:{borrow.BorrowId}\t Book Id={borrow.BookId}\t User Id:{borrow.UserId}\t Borrow Date:{borrow.BorrowDate}\t Status:{borrow.BookStatus}");
                }
            }
        }

        public static void WalletAmount()
        {
            System.Console.WriteLine("Enter amount to to recharge");
            int amount=int.Parse(Console.ReadLine());
            currentUser.WalletAmount+=amount;
        }





         public static void DefaultValues()
         {
            UserDetails user1=new UserDetails("Ravi chandran",Gender.Male,Department.EEE,9838388333,"ravi@gamail.com",500);
            userList.Add(user1);
             
             UserDetails user2=new UserDetails("Priya Dharshini",Gender.Female,Department.CSE,94666666655,"priya@gamail.com",600);
            userList.Add(user2);

            BookDetails book1=new BookDetails("C#","Author1",3);
            BookDetails book2=new BookDetails("HTML","Author2",5);
            BookDetails book3=new BookDetails("Java","Author1",3);
            BookDetails book4=new BookDetails("JS","Author1",3);
            BookDetails book5=new BookDetails("TS","Author2",2);

            bookList.Add(book1);
            bookList.Add(book2);
            bookList.Add(book3);
            bookList.Add(book4);
            bookList.Add(book5);

            BorrowDetails borrow1=new BorrowDetails(book1.BookId,user1.UserId,new DateTime(2022,04,10),Status.Issued);
            BorrowDetails borrow2=new BorrowDetails(book3.BookId,user1.UserId,new DateTime(2022,02,12),Status.Returned);
            BorrowDetails borrow3=new BorrowDetails(book4.BookId,user1.UserId,new DateTime(2022,04,15),Status.Issued);
            BorrowDetails borrow4=new BorrowDetails(book5.BookId,user2.UserId,new DateTime(2022,04,11),Status.Returned);
            BorrowDetails borrow5=new BorrowDetails(book2.BookId,user2.UserId,new DateTime(2022,04,11),Status.Issued);

            borrowList.Add(borrow1);
            borrowList.Add(borrow2);
            borrowList.Add(borrow3);
            borrowList.Add(borrow4);
            borrowList.Add(borrow5);

    

            

         }
    }
}