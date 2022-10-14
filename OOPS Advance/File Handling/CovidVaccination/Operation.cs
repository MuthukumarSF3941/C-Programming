using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidVaccination
{
    public static class Operation
    {

        public static UserDetails currentUser=null;

        public static List<UserDetails> userList=new List<UserDetails>();

        public static List<VaccineDetails> vaccineList=new List<VaccineDetails>();

        public static List<VaccinationDetails> vaccinateList=new List<VaccinationDetails>();

        public static void MainMenu()
        {
          int choice;
          do
          {

            System.Console.WriteLine("Enter your choice  1.Benificary Registeration\t 2.LogIn\t 3.Get Vaccination Info\t  4.Exit");
            choice=int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                {
                    System.Console.WriteLine("Benificary Registeration");
                    Registration();

                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("Login");
                    LogIn();
                    break;
                }
                case 3:
                {
                    System.Console.WriteLine("Get VaccinationInfo");
                    break;
                }
                case 4:
                {
                    System.Console.WriteLine("Exit");
                    break;
                }
                    
                default:
                System.Console.WriteLine("Invalid Entry");
                    break;
            }
            
            
          } while (choice!=4);
        }

        public static void Registration()
        {
          System.Console.WriteLine("Enter your Name");
          string name=Console.ReadLine();
          
          System.Console.WriteLine("Enter your Age ");
          int age=int.Parse(Console.ReadLine());

          System.Console.WriteLine("Enter your Gender");
          Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);

          System.Console.WriteLine("Enter your Mobile Number");
          long mobile=long.Parse(Console.ReadLine());

          System.Console.WriteLine("Enter city");
          string city=Console.ReadLine();
          
          UserDetails users=new UserDetails(name,gender,age,city,mobile);
          userList.Add(users);

          System.Console.WriteLine($"Your Registeration Number is :{users.RegisterNumber}");
        
        }

        public static void LogIn()
        {
            System.Console.WriteLine("Enter your Register Number");
            string regId=Console.ReadLine().ToUpper();
            foreach (UserDetails user in userList)
            {
                if(user.RegisterNumber==regId)
                {
                    System.Console.WriteLine("Login Successfull");
                    currentUser=user;

                }
            }
            
        }

        public static void subMenu()
        {
            int choice;
            do
            {
                System.Console.WriteLine("Enter your choice 1.Show muy Details\t 2.Take vaccination\t 3.My vaccination Info\t 4.Next Due Date\t 5.Exit");
                choice=int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                    {
                        System.Console.WriteLine("Show my Details");
                        ShowDetails();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("Take Vaccination");
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("My vaccination info");
                        break;
                    }
                    case 4:
                    {
                        System.Console.WriteLine("Next due Date");
                        break;
                    }
                    case 5:
                    {
                        System.Console.WriteLine("Exit Sub Menu");
                        break;
                    }
                        
                    default:
                        break;
                }

                
                
            } while (choice!=5);
        }


        public static void ShowDetails()
        {
            foreach (UserDetails user in userList)
            {
                if(user.RegisterNumber==currentUser.RegisterNumber)
                {
                    System.Console.WriteLine($"RegisterNumber:{user.RegisterNumber}\n Name{user.Name}\n Gender:{user.Gender}\n Age:{user.Age} Mobile Number:{user.Mobile}\n City:{user.City} ");
                }
            }

        }

        /*public static void takeVaccination()
        {
            showVaccine();
            System.Console.WriteLine("Enter Vaccin Id");
            string vaccinId=Console.ReadLine().ToUpper();

            foreach (VaccineDetails vaccine in vaccineList)
            {
                if (vaccine.VaccineId==vaccinId)
                {
                   
                            foreach (VaccinationDetails vaccinate in vaccinateList)
                            {
                               foreach (UserDetails user in userList)
                               {
                                if(user.RegisterNumber==currentUser.RegisterNumber)
                               {
                                if(currentUser.RegisterNumber==vaccinate.RegisterNumber)
                                {
                                   if(vaccinate.VaccinateId=="")
                                   {
                                    if(currentUser.Age>14)
                                    {

                                     System.Console.WriteLine("Vaccinated successfully"); 
                                     VaccinationDetails vaccination=new VaccinationDetails(currentUser.RegisterNumber,vaccine.VaccineId,1,DateTime.Now)  ;
                                     vaccinateList.Add(vaccination);
                                    }
                                    else
                                    {
                                         if(vacc)
                                         {

                                         }
                                    }
                                   }
                                }

                               }
                               }
                            }
                        
                    
                }
            }
            

        }*/

        public static void showVaccine()
        {
            foreach (VaccineDetails vaccine in vaccineList)
            {
                System.Console.WriteLine($"Vaccine Id:{vaccine.VaccineId}\t Vaccine Name:{vaccine.VaccineName}\t Available Dose:{vaccine.DoseAvailable}");
            }
        }
        





        public static void defaultValue()
        {
            UserDetails user1=new UserDetails("Ravichandran",Gender.Male,21,"Chennai",8484484);
            userList.Add(user1);

            UserDetails user2=new UserDetails("Baskaran",Gender.Male,22,"Chennai",8484747);
            userList.Add(user2);

            VaccineDetails vaccine1=new VaccineDetails(VaccineName.Covishield,50);
            vaccineList.Add(vaccine1);

             VaccineDetails vaccine2=new VaccineDetails(VaccineName.Covaccine,50);
            vaccineList.Add(vaccine2);

            VaccinationDetails vaccinnate1=new VaccinationDetails(user1.RegisterNumber,vaccine1.VaccineId,1,new DateTime(2021,11,11));
            vaccinateList.Add(vaccinnate1);

            VaccinationDetails vaccinnate2=new VaccinationDetails(user1.RegisterNumber,vaccine1.VaccineId,2,new DateTime(2022,03,11));
            vaccinateList.Add(vaccinnate2);

            VaccinationDetails vaccinnate3=new VaccinationDetails(user2.RegisterNumber,vaccine2.VaccineId,1,new DateTime(2022,04,04));
            vaccinateList.Add(vaccinnate3);




        }
        
    }
}