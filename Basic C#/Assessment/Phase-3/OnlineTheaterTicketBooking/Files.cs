using System.IO;
namespace OnlineTheaterTicketBooking
{
    public static class Files
    {
        public static void CreateFiles()
        {
            //creating folder for Ticket Booking Application
            if(!Directory.Exists("TicketBooking"))
            {
                Directory.CreateDirectory("TicketBooking");
            }


            //creating a file to store the user details
            if(!File.Exists("TicketBooking/UserDetails.csv"))
            {
                File.Create("TicketBooking/UserDetails.csv");
            }
            
            //creating a file to store the Theater details
            if(!File.Exists("TicketBooking/TheaterDetails.csv"))
            {
                File.Create("TicketBooking/TheaterDetails.csv");
            }
             
             //creating a file to store the Movie details
             if(!File.Exists("TicketBooking/MovieDetails.csv"))
            {
                File.Create("TicketBooking/MovieDetails.csv");
            }


             //creating a file to store the Screening details
             if(!File.Exists("TicketBooking/ScreeningDetails.csv"))
            {
                File.Create("TicketBooking/ScreeningDetails.csv");
            }

            //creating a file to store the Booking details
              if(!File.Exists("TicketBooking/BookingDetails.csv"))
            {
                File.Create("TicketBooking/BookingDetails.csv");
            }
        }
        
        public static void ReadFiles()
        {

            //Reading data from userDetails file
            string[] user=File.ReadAllLines("TicketBooking/UserDetails.csv");
            foreach (string user1 in user)
            {
                UserDetails user2=new UserDetails(user1);
                Operation.userList.Add(user2);

            }


            //Reading data from Theater Details file
            string[] theater=File.ReadAllLines("TicketBooking/TheaterDetails.csv");
            foreach (string theater1 in theater)
            {
                TheaterDetails theater2=new TheaterDetails(theater1);
                Operation.TheaterList.Add(theater2);

            }

             //Reading data from Movie Details file
            string[] movie=File.ReadAllLines("TicketBooking/MovieDetails.csv");
            foreach (string movie1 in movie)
            {
                MovieDetails movie2=new MovieDetails(movie1);
                Operation.movieList.Add(movie2);

            }


            //Reading data from Screening Details file
            string[] screen=File.ReadAllLines("TicketBooking/ScreeningDetails.csv");
            foreach (string screen1 in screen)
            {
                ScreeningDetatils screen2=new ScreeningDetatils(screen1);
                Operation.screeningList.Add(screen2);

            }

            //Reading data from Booking Details file
            string[] book=File.ReadAllLines("TicketBooking/BookingDetails.csv");
            foreach (string book1 in book)
            {
                BookingDetails book2=new BookingDetails(book1);
                Operation.bookingList.Add(book2);

            }
        }

        public static void WriteFiles()
        {
            //write data to user Details file
            string[] userDetails=new string[Operation.userList.Count];

            for (int i = 0; i < Operation.userList.Count; i++)
            {
                userDetails[i]=Operation.userList[i].UserId+","+Operation.userList[i].Name+","+Operation.userList[i].Age+","+Operation.userList[i].PhoneNumber+","+Operation.userList[i].WalletBalance;
            }
            File.WriteAllLines("TicketBooking/UserDetails.csv",userDetails);

  
            //write data to theater Details file
            string[] theaterDetails=new string[Operation.TheaterList.Count];

            for (int i = 0; i < Operation.TheaterList.Count; i++)
            {
                theaterDetails[i]=Operation.TheaterList[i].TheaterId+","+Operation.TheaterList[i].TheaterName+","+Operation.TheaterList[i].TheaterLocation;
            }
            File.WriteAllLines("TicketBooking/TheaterDetails.csv",theaterDetails);


            //write data to Movie Details file
            string[] movieDetails=new string[Operation.movieList.Count];

            for (int i = 0; i < Operation.movieList.Count; i++)
            {
                movieDetails[i]=Operation.movieList[i].MovieId+","+Operation.movieList[i].MovieName+","+Operation.movieList[i].Language;
            }
            File.WriteAllLines("TicketBooking/MovieDetails.csv",movieDetails);


            //write data to Screening Details file
            string[] screeningDetails=new string[Operation.screeningList.Count];

            for (int i = 0; i < Operation.screeningList.Count; i++)
            {
                screeningDetails[i]=Operation.screeningList[i].MovieId+","+Operation.screeningList[i].TheaterId+","+Operation.screeningList[i].SeatsAvailable+","+Operation.screeningList[i].TicketPrice;
            }
            File.WriteAllLines("TicketBooking/ScreeningDetails.csv",screeningDetails);


            //write data to Booking Details file
            string[] bookingDetails=new string[Operation.bookingList.Count];

            for (int i = 0; i < Operation.bookingList.Count; i++)
            {
                bookingDetails[i]=Operation.bookingList[i].BookingId+","+Operation.bookingList[i].UserId+","+Operation.bookingList[i].MovieId+","+Operation.bookingList[i].TheaterId+","+Operation.bookingList[i].SeatCount+","+Operation.bookingList[i].TotalAmount+","+Operation.bookingList[i].BookingStatus;
            }
            File.WriteAllLines("TicketBooking/BookingDetails.csv",bookingDetails);
        }
   
    }
}