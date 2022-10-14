

namespace OnlineTheaterTicketBooking
{
    /// <summary>
    /// Inherited class that creates properties to the userDetails
    /// </summary>
    public class UserDetails : PersonalDetails,IWallet
    {

        /// <summary>
        /// used to create an auto incremented field
        /// </summary>
        private static int s_userId=1000;
        /// <summary>
        /// used as the property for user Id
        /// </summary>
        /// <value></value>
        public string UserId { get; set; }

        /// <summary>
        /// used as the property to store the user balance
        /// </summary>
        /// <value></value>
        public double WalletBalance { get; set; }

        /// <summary>
        /// cunstructor used to assign values to the properties
        /// </summary>
        /// <param name="name">used to assign user name</param>
        /// <param name="age">used to assign user age</param>
        /// <param name="phonenumber">used to assign user phone number</param>
        /// <param name="walletBalance">used to store assign Wallet balance</param>
        /// <returns></returns>
        public UserDetails(string name,int age,long phonenumber,double walletBalance):base( name, age, phonenumber)
        {
            s_userId++;
            UserId="UID"+s_userId;;
            WalletBalance=walletBalance;

        }

          public UserDetails(string data)
        {

            string[] value=data.Split(',');
            s_userId=int.Parse(value[0].Remove(0,3));
            UserId=value[0];
            Name=value[1];
            Age=int.Parse(value[2]);
            PhoneNumber=long.Parse(value[3]);
            WalletBalance=double.Parse(value[4]);

        }

      

        public void WalletRecharge(double amount)
        {
          WalletBalance+=amount;
          System.Console.WriteLine("Your total balance is:"+WalletBalance);
        }
    }
}