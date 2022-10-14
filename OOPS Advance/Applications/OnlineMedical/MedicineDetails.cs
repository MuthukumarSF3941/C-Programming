using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedical
{
    public class MedicineDetails
    {
        public static int s_medicineId=100;

        public string MedicineId { get; set; }

        public string MedicineName { get; set; }

        public int AvailbleCount { get; set; }

        public double Price { get; set; }

        public DateTime DateOfExpiry { get; set; }
        
        

        public MedicineDetails(string madicineName,int available,double price,DateTime expiry)
        {

            s_medicineId++;
            MedicineId="MD"+s_medicineId;
            MedicineName=madicineName;
            AvailbleCount=available;
            Price=price;
            DateOfExpiry=expiry;

        }

        
        public MedicineDetails(string data)
        {
           string[] value=data.Split(',');
            s_medicineId=int.Parse(value[0].Remove(0,2));
            MedicineId=value[0];
            MedicineName=value[1];
            AvailbleCount=int.Parse(value[2]);
            Price=double.Parse(value[3]);
            DateOfExpiry=DateTime.ParseExact(value[4],"dd/MM/yyyy",null);

        }
 
        
        
        
        
        
        
        
        
        
    }
}