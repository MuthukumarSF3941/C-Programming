
namespace OnlineTheaterTicketBooking
{

    /// <summary>
    /// calss that used to assign properties for the Theater details
    /// </summary>
    public class TheaterDetails
    {
        /// <summary>
        /// used to create the auto incremented id
        /// </summary>
        private static int s_theaterId=300;

        /// <summary>
        /// used as the property to theater Id
        /// </summary>
        /// <value></value>
        public string TheaterId { get; set; }


        /// <summary>
        /// used as the property for theater Name
        /// </summary>
        /// <value></value>
        public string TheaterName { get; set; }

        /// <summary>
        /// used as the property for theater Location
        /// </summary>
        /// <value></value>
        public string TheaterLocation { get; set; }

        /// <summary>
        /// cunstructor used to assign values to the properties
        /// </summary>
        /// <param name="theatreName">assign the theater name to the property</param>
        /// <param name="theaterLocation">assign the Theater Location to the property</param>
        public TheaterDetails(string theatreName,string theaterLocation)
        {
            s_theaterId++;
            TheaterId="TID"+s_theaterId;
            TheaterName=theatreName;
            TheaterLocation=theaterLocation;

        }

         public TheaterDetails(string data)
        {
            string[] value=data.Split(',');
            s_theaterId=int.Parse(value[0].Remove(0,3));
            TheaterId=value[0];
            TheaterName=value[1];
            TheaterLocation=value[2];

        }
        
        
        
        
        
        
    }
}