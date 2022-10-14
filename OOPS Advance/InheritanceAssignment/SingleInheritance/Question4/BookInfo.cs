using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question4
{
    public class BookInfo : DepartmentDetails
    {

        private static int s_bookId=100;

        public string BookId { get; set; }

        public string BookName { get; set; }

        public string AuthorName { get; set; }

        public int Price { get; set; }

        public BookInfo(string dept,string degree,string bookName,string authorName,int price):base( dept, degree)
        {

            s_bookId++;
            BookId="BID"+s_bookId;

            DepartmentName=dept;
            BookName=bookName;
            AuthorName=authorName;


        }

        public void show()
        {
            System.Console.WriteLine($" Book Id:{BookId}\n Department:{DepartmentName}\n Degree:{Degree}\n AuthorName:{AuthorName}\n Price:{Price}");
        }
        
        
        
        
        
        
        
        
    }
}