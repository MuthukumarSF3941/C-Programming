using System;


namespace FoodDelivery
{
    public  enum Status {Default,Initiated,Booked,Cancelled}
    public class BookingDetails
    {
        private static int s_bookingId=3000;

        public string BookingId { get; set; }

        public string CustomerId { get; set; }

        public int TotalPrice { get; set; }

        public DateTime DateBooked { get; set; }

        public Status BookingStatus { get; set; }

        public BookingDetails(string customerId,int totalPrice,DateTime dateBooked,Status bookingStatus)
        {
            s_bookingId++;
            BookingId="BID"+s_bookingId;
            CustomerId=customerId;
            TotalPrice=totalPrice;
            DateBooked=dateBooked;
            BookingStatus=bookingStatus;
        }

         public BookingDetails(string data)
          {
            string[] value=data.Split(',');
            s_bookingId=int.Parse(value[0].Remove(0,3));
            BookingId=value[0];
            CustomerId=value[1];
            TotalPrice=int.Parse(value[2]);
            DateBooked=DateTime.ParseExact(value[3],"dd/MM/yyyy",null);
            BookingStatus=Enum.Parse<Status>(value[4]);
        }

        
        
        
        
        
        
        
        
        
        
    }
}