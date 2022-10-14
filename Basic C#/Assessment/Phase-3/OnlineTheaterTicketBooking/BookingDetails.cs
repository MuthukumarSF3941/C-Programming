using System;

/// <summary>
/// used to 
/// </summary>
namespace OnlineTheaterTicketBooking
{
    public enum Status{Booked,Cancelled}
    /// <summary>
    /// uesd to create containers for Booking details
    /// </summary>
    public class BookingDetails
    {
        /// <summary>
        /// used to craete an  auto incemented Id
        /// </summary>
        private static int s_bookindId=7000;

        /// <summary>
        /// used to store the generated booking Id
        /// </summary>
        /// <value></value>
        public string BookingId { get; set; }

         /// <summary>
         /// used to store the User Id
         /// </summary>
         /// <value></value>
        public string UserId { get; set; }

        /// <summary>
        /// used to store the Movie Id
        /// </summary>
        /// <value></value>
        public string MovieId { get; set; }

        /// <summary>
        /// used to store the Theater ID
        /// </summary>
        /// <value></value>
        public string TheaterId { get; set; }

         /// <summary>
         /// used to store the seat count Entered by the user
         /// </summary>
         /// <value></value>
        public int SeatCount { get; set; }


        /// <summary>
        /// used to store the calculated total amount
        /// </summary>
        /// <value></value>
        public Double TotalAmount { get; set; }

        /// <summary>
        /// used to store the  status of the booking
        /// </summary>
        /// <value></value>
        public Status BookingStatus { get; set; }

        /// <summary>
        /// used to assign the parameters to the properties
        /// </summary>
        /// <param name="userId">input the user id into the cunstructor</param>
        /// <param name="movieId">input the Movie id into the cunstructor</param>
        /// <param name="theaterId">input the Theater id into the cunstructor</param>
        /// <param name="seatCount">input the Seat Count  into the cunstructor</param>
        /// <param name="totalAmount">input the TotalAmount  into the cunstructor</param>
        /// <param name="bookingStatus">input the Booking Status  into the cunstructor</param>
        public BookingDetails(string userId,string movieId,string theaterId,int seatCount,double totalAmount,Status bookingStatus)
        {
            s_bookindId++;

            BookingId="BID"+s_bookindId;
            UserId=userId;
            MovieId=movieId;
            TheaterId=theaterId;
            SeatCount=seatCount;
            TotalAmount=totalAmount;
            BookingStatus=bookingStatus;
        }
        /// <summary>
        /// used to read the data in the list
        /// </summary>
        /// <param name="data">the string value of datas passed as parameter</param>

          public BookingDetails(string data)
        {
            string[] value=data.Split(',');
            s_bookindId=int.Parse(value[0].Remove(0,3));

            BookingId=value[0];
            UserId=value[1];
            MovieId=value[2];
            TheaterId=value[3];
            SeatCount=int.Parse(value[4]);
            TotalAmount=double.Parse(value[5]);
            BookingStatus=Enum.Parse<Status>(value[6],true);
        }
        
        


        
        
        
        
        
        
        
        
        
        
        
        
    }
}