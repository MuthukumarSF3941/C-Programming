using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGrocery
{
    public interface IBalance
    {
        public double WalletBalance { get; set; }

        void WalletRecharge();
        
        
    }
}