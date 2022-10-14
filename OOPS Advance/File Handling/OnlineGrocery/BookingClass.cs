using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGrocery
{

    public enum status{Default,Initiated,Booked,Cancelled}
    
    public class BookingClass
    {
        private static int s_bookingId=3000;

        public string BookingId { get; set; }

        public string CustomerId { get; set; }

        public Double TotalPrice { get; set; }

        public DateTime DateofBooking { get; set; }

        public status BookingStatus { get; set; }

        public BookingClass(string customerId,double totalPrice,DateTime dateBooked,status bookingStatus)
        {
            s_bookingId++;

            BookingId="BID"+s_bookingId;
            CustomerId=customerId;
            TotalPrice=totalPrice;
            DateofBooking=dateBooked;
            BookingStatus=bookingStatus;
        }


          public BookingClass(string data)
        {

            string[] value=data.Split(',');
            s_bookingId=int.Parse(value[0].Remove(0,3));

            BookingId=value[0];
            CustomerId=value[1];
            TotalPrice=double.Parse(value[2]);
            DateofBooking=DateTime.ParseExact(value[3],"dd/MM/yyyy",null);
            BookingStatus=Enum.Parse<status>(value[4],true);
        }


        public void ShowBooking()
        {
            System.Console.WriteLine($"Booking Id;{BookingId} CustomerId:{CustomerId}  Total Price:{TotalPrice} Date booked:{DateofBooking.ToShortDateString()}  Booking Status:{BookingStatus}");
        }
        
        
        
        
        
        
        
        
        
        
    }
}