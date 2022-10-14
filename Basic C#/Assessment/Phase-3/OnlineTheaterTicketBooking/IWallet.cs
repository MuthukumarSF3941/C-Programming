

namespace OnlineTheaterTicketBooking
{
    /// <summary>
    /// interface that had to inherited by the user class
    /// </summary>
    public interface IWallet
    {
        /// <summary>
        /// uesd to store the wallet Balance of the user
        /// </summary>
        /// <value></value>
        public double WalletBalance { get; set; }
  
    /// <summary>
    /// Abstract method that need to get implemented in the inherited class
    /// </summary>
    /// <param name="amount">used to pass the users input to the method</param>
    void WalletRecharge(double amount);
        
        
    }
}