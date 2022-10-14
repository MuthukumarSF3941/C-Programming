

namespace OnlineTheaterTicketBooking
{
     /// <summary>
     /// used as containers for the personal Detaills of the user
     /// </summary>
    public class PersonalDetails
    {
        /// <summary>
        /// used to assign the Name of the user
        /// </summary>
        /// <value></value>
        public string Name { get; set; }

        /// <summary>
        /// used to assign the age of the user
        /// </summary>
        /// <value></value>
        public int Age { get; set; }


        /// <summary>
        /// used to assign the value to the Phone number of the user
        /// </summary>
        /// <value></value>
        public long PhoneNumber { get; set; }


        /// <summary>
        /// Default constructor to inherit the data to the user class
        /// </summary>
        public PersonalDetails()
        {

        }
        
        /// <summary>
        /// contructor to assign values to the properties
        /// </summary>
        /// <param name="name">used to assign name</param>
        /// <param name="age">used to assign age</param>
        /// <param name="phonenumber">used to assign phone Number</param>
        public PersonalDetails(string name,int age,long phonenumber)
        {
            Name=name;
            Age=age;
            PhoneNumber=phonenumber;
        }
        
                
        
        
        
    }
}