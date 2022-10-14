using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidVaccination
{
    public enum Gender{Male,Female};
    public class UserDetails
    {

        static int s_registerNumber=1000;

        public string RegisterNumber { get; set; }
        
        
        public string Name { get; set; }

        public Gender Gender { get; set; }

        public int Age { get; set; }

        public string City { get; set; }

        public long Mobile { get; set; }

        public UserDetails(string name,Gender gender,int age,string city,long mobile)
        {
            s_registerNumber++;
            RegisterNumber="BID"+s_registerNumber;
            Name=name;
            Gender=gender;
            Age=age;
            City=city;
            Mobile=mobile;

        }

          public UserDetails(string data)
        {

            string[] values=data.Split(',');
            
            RegisterNumber=values[0];
            s_registerNumber=int.Parse(values[0].Remove(0,3));
            Name=values[1];
            Gender=Enum.Parse<Gender>(values[2]);
            Age=int.Parse(values[3]);
            City=values[4];
            Mobile=long.Parse(values[5]);

        }
        
        
        
        
        
        
        
        
        
        
    }
}