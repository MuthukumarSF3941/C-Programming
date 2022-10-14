using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLibrary
{

    public enum Status{Issued,Returned}
    public class BorrowDetails
    {
        static int s_borrowId=300;

        public string BorrowId { get; set; }

        public string BookId { get; set; }

        public string UserId { get; set; }

        public DateTime BorrowDate { get; set; }

        public Status BookStatus { get; set; }
        
        

        public BorrowDetails(string bookId,string userId,DateTime borrowDate,Status bookStatus)
        {
           s_borrowId++;

           BorrowId="LB"+s_borrowId;
           BookId=bookId;
           UserId=userId;
           BorrowDate=borrowDate;
           BookStatus=bookStatus;

        }
        
        
        
        
        
        
        
        
    }
}