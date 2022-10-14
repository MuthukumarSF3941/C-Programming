using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidVaccination
{
    public enum VaccineName{Covishield,Covaccine};
    public class VaccineDetails
    {
        static int s_vaccineId=100;

        public string VaccineId { get; set; }

        public VaccineName VaccineName { get; set; }

        public int DoseAvailable { get; set; }

        public VaccineDetails(VaccineName vaccineName,int doseAvailable)
        {
             s_vaccineId++;
             VaccineId="CID"+s_vaccineId;
             VaccineName=vaccineName;
             DoseAvailable=doseAvailable;

        }
        
        
        
        
        
        
    }
}