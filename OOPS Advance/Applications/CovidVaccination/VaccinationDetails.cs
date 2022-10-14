using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidVaccination
{
    
    public class VaccinationDetails
    {
        static int s_vacciateId=1000;

        public string VaccinateId { get; set; }

        public string RegisterNumber { get; set; }

        public string VaccinId{ get; set; }
        
        

       public int DoseNumber { get; set; }

       public DateTime VaccinateDate { get; set; }

       public VaccinationDetails(string registerNumber,string vaccinId,int doseNumber,DateTime vaccinateDate)
       {
         s_vacciateId++;
         VaccinateId="VID"+s_vacciateId;
         VaccinId=vaccinId;
         DoseNumber=doseNumber;
         VaccinateDate=vaccinateDate;
         

    
       }
       
       
       
       


        
        
        
        


        
        
        
    }
}