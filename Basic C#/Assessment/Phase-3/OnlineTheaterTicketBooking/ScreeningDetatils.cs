using System;


namespace OnlineTheaterTicketBooking
{
    /// <summary>
    /// class to create containers to store the screening Details
    /// </summary>
    public class ScreeningDetatils
    {

        /// <summary>
        /// used as the property for Movie Id
        /// </summary>
        /// <value></value>
        public string MovieId { get; set; }

        /// <summary>
        /// used as the property for Theater Id
        /// </summary>
        /// <value></value>
        public string TheaterId { get; set; }

        /// <summary>
        /// used as the property for Availabe seat count
        /// </summary>
        /// <value></value>
        public int SeatsAvailable { get; set; }

        /// <summary>
        /// used as the property for Ticket Price
        /// </summary>
        /// <value></value>
        public Double TicketPrice { get; set; }

         /// <summary>
         /// constructor that used to assign the valus
         /// </summary>
         /// <param name="movieId">used to assign movie id</param>
         /// <param name="theaterId">used to assign Theater id</param>
         /// <param name="seatsAvailable">used to assign Available seat count</param>
         /// <param name="ticketPrice">used to assign Ticket Price</param>
        public ScreeningDetatils(string movieId,string theaterId,int seatsAvailable,double ticketPrice)
        {
            MovieId=movieId;
            TheaterId=theaterId;
            SeatsAvailable=seatsAvailable;
            TicketPrice=ticketPrice;

        }

        public ScreeningDetatils(string data)
        {
            string[] value=data.Split(',');
            MovieId=value[0];
            TheaterId=value[1];
            SeatsAvailable=int.Parse(value[2]);
            TicketPrice=double.Parse(value[3]);

        }
        
        
        
        
        
        
        
        
    }
}
