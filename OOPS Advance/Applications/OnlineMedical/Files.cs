using System.IO;

namespace OnlineMedical
{
    public static class Files
    {
       public static void Create()
       {
        if(!Directory.Exists("Medical"))
        {
            Directory.CreateDirectory("Medical");
        }

        if(!File.Exists("Medical/User.csv"))
        {
            File.Create("Medical/User.csv");
        }

         if(!File.Exists("Medical/Medicine.csv"))
        {
            File.Create("Medical/Medicine.csv");
        }

         if(!File.Exists("Medical/Order.csv"))
        {
            File.Create("Medical/Order.csv");
        }


       }   

       public static void ReadFiles()
       {
        string[] users=File.ReadAllLines("Medical/User.csv");
        
        foreach (string user in users)
        {
            UserDetails user1=new UserDetails(user);
            Operation.userList.Add(user1);
        }

        string[] medicine=File.ReadAllLines("Medical/Medicine.csv");

        foreach (string med in medicine)
        {
            MedicineDetails medicine1=new MedicineDetails(med);
            Operation.medicineList.Add(medicine1);
        }

        string[] orders=File.ReadAllLines("Medical/Order.csv");
         foreach (string order in orders)
         {
            OrderDetails order1=new OrderDetails(order);
            Operation.orderList.Add(order1);
         }
       }


       public static void WiteFiles()
       {
        string[] userDetails=new string[Operation.userList.Count];

        for (int i = 0; i < Operation.userList.Count; i++)
        {
            userDetails[i]=Operation.userList[i].UserId+","+Operation.userList[i].Name+","+Operation.userList[i].Age+","+Operation.userList[i].City+","+Operation.userList[i].Mobile+","+Operation.userList[i].Balance;

        }
        File.WriteAllLines("Medical/User.csv",userDetails);

        string[] MedicineDetails=new string[Operation.medicineList.Count];

        for (int i = 0; i < Operation.medicineList.Count; i++)
        {
            MedicineDetails[i]=Operation.medicineList[i].MedicineId+","+Operation.medicineList[i].MedicineName+","+Operation.medicineList[i].AvailbleCount+","+Operation.medicineList[i].Price+","+Operation.medicineList[i].DateOfExpiry.ToShortDateString();
        }
        File.WriteAllLines("Medical/Medicine.csv",MedicineDetails);

        string[] orderDetails=new string[Operation.orderList.Count];

        for (int i = 0; i < Operation.orderList.Count; i++)
        {
            orderDetails[i]=Operation.orderList[i].OrderId+","+Operation.orderList[i].UserId+","+Operation.orderList[i].MedicineId+","+Operation.orderList[i].MedicineCount+","+Operation.orderList[i].TotalPrice+","+Operation.orderList[i].OrderDate.ToShortDateString()+","+Operation.orderList[i].OrderStatus;
        }
        File.WriteAllLines("Medical/Order.csv",orderDetails);

       }

       

    }
}