using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedical
{
    public class UserDetails
    {
        public static int s_UserId=1000;

        public string Name { get; set; }

        public string UserId { get; set; }
        
        

        public int  Age { get; set; }

        public string City { get; set; }

        public long Mobile { get; set; }

        public Double Balance { get; set; }

        public UserDetails(string name,int age,string city,long mobile,double balance)
        {
            s_UserId++;

            UserId="UID"+s_UserId;
            Name=name;
            Age=age;
            City=city;
            Mobile=mobile;
            Balance=balance;

        }

         public UserDetails(string data)
        {
            string[] value=data.Split(',');
            s_UserId=int.Parse(value[0].Remove(0,3));

            UserId=value[0];
            Name=value[1];
            Age=int.Parse(value[2]);
            City=value[3];
            Mobile=long.Parse(value[4]);
            Balance=double.Parse(value[5]);
        

        }

        
        
        
        
        
        
        
        
        
        
        
    }
}