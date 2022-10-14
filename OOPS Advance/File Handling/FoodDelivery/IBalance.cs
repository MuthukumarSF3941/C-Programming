using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDelivery
{
    public interface IBalance
    {
       public string WalletAmount { get; set; }

       abstract void WalletRecarge();
       
       
       
        
        
    }
}