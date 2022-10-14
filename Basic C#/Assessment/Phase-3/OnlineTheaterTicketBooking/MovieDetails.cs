


namespace OnlineTheaterTicketBooking
{
    /// <summary>
    /// class that used to contains the value of movie details from the user
    /// </summary>
    public class MovieDetails
    {
        /// <summary>
        /// used as the property to contain Movie ID
        /// </summary>
        /// <value></value>
        public string MovieId { get; set; }


        /// <summary>
        /// used as the property to contain Movie Name
        /// </summary>
        /// <value></value>
        public string MovieName { get; set; }
        

        /// <summary>
        /// used as the property to contain Movie Language
        /// </summary>
        /// <value></value>
        public string Language { get; set; }

        /// <summary>
        /// used to assign values to the properties
        /// </summary>
        /// <param name="movieId">used to assign the movie Id</param>
        /// <param name="movieName">used to set the Movie Name</param>
        /// <param name="language">used to set the Language</param>
        public MovieDetails(string movieId,string movieName,string language)
        {
            MovieId=movieId;
            MovieName=movieName;
            Language=language;

        }

          public MovieDetails(string data)
        {
            string[] value=data.Split(',');

            MovieId=value[0];
            MovieName=value[1];
            Language=value[2];
            
        }
        
        
        
        
        
        
    }
}