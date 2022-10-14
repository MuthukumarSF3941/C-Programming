using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace CovidVaccination
{
    public static class Files
    {
        public static void Create()
        {
           if(!Directory.Exists("Covid"))
           {
            Directory.CreateDirectory("Covid");
           }

           if(!File.Exists("Covid/uesr.csv"))
           {
            File.Create("Covid/uesr.csv");
           }
        }

        public static void ReadFile()
        {
            string[] users=File.ReadAllLines("Covid/uesr.csv");

            foreach (string user in users)
            {
                UserDetails user1=new UserDetails(user);
               Operation.userList.Add(user1);
            }
        }

        public static void WriteFile()
        {
            string[] UserDetails=new string[Operation.userList.Count];

            for (int i = 0; i < Operation.userList.Count; i++)
            {
                UserDetails[i]=Operation.userList[i].RegisterNumber+","+Operation.userList[i].Name+","+Operation.userList[i].Gender+","+Operation.userList[i].Age+","+Operation.userList[i].City+","+Operation.userList[i].Mobile;
            }
            File.WriteAllLines("Covid/uesr.csv",UserDetails);
        }
    }
}