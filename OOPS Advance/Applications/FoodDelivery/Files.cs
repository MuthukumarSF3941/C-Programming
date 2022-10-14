using System.IO;

namespace FoodDelivery
{
    public static class Files
    {
           public static void Create()
           {
               if(!Directory.Exists("Hotel"))
               {
                Directory.CreateDirectory("Hotel");

               }

               if(!File.Exists("Hotel/Customers.csv"))
               {
                 File.Create("Hotel/Customers.csv");
               }

               if(!File.Exists("Hotel/Foods.csv"))
               {
                File.Create("Hotel/Foods.csv");
               }

               if(!File.Exists("Hotel/Orders.csv"))
               {
                File.Create("Hotel/Orders.csv");


               }

               if(!File.Exists("Hotel/Booking.csv"))
               {
                File.Create("Hotel/Booking.csv");
               }
           }

        public static void ReadFiles()
        {
            string[] user=File.ReadAllLines("Hotel/Customers.csv");

            foreach (string customer in user)
            {
               CustomerRegistration one=new CustomerRegistration(customer);
               Operation.customerList.Add(one); 
            }

             string[] foods=File.ReadAllLines("Hotel/Foods.csv");
            foreach (string item in foods)
            {
                FoodDetails food=new FoodDetails(item);
                Operation.FoodList.Add(food);

            }


            string[] orders=File.ReadAllLines("Hotel/Orders.csv");

            foreach(string  order in orders)
            {
                OrderDetails order1=new OrderDetails(order);
                Operation.orderList.Add(order1);

            }

           
            string[] booking=File.ReadAllLines("Hotel/Booking.csv");

            foreach (string item in booking)
            {
                BookingDetails book=new BookingDetails(item);
                Operation.bookingList.Add(book);
            }
        }

        public static void WriteLines()
        {
            string[] CustomerRegistration=new string[Operation.customerList.Count];
            for(int i=0;i<Operation.customerList.Count;i++)
            {
                CustomerRegistration[i]=Operation.customerList[i].CustomerId+","+Operation.customerList[i].Name+","+Operation.customerList[i].FatherName+","+Operation.customerList[i].Gender+","+Operation.customerList[i].Mobile+","+Operation.customerList[i].DOB.ToShortDateString()+","+Operation.customerList[i].MailId+","+Operation.customerList[i].Location+","+Operation.customerList[i].WalletAmount;
            }
            File.WriteAllLines("Hotel/Customers.csv",CustomerRegistration);

            string[] FoodDetails=new string[Operation.FoodList.Count];
            for (int i = 0; i < Operation.FoodList.Count; i++)
            {
                FoodDetails[i]=Operation.FoodList[i].FoodId+","+Operation.FoodList[i].FoodName+","+Operation.FoodList[i].PricePerQuantity;
            }
            File.WriteAllLines("Hotel/Foods.csv",FoodDetails);

            string[] OrderDetails=new string[Operation.orderList.Count];

            for (int i = 0; i < Operation.orderList.Count; i++)
            {
                OrderDetails[i]=Operation.orderList[i].OrderId+","+Operation.orderList[i].BookingId+","+Operation.orderList[i].FoodId+","+Operation.orderList[i].PurchaseCount+","+Operation.orderList[i].PriceofOrder;
            }

            File.WriteAllLines("Hotel/Orders.csv",OrderDetails);

            string[] BookingDetails=new string[Operation.bookingList.Count];
            for (int i = 0; i < Operation.bookingList.Count; i++)
            {
                BookingDetails[i]=Operation.bookingList[i].BookingId+","+Operation.bookingList[i].CustomerId+","+Operation.bookingList[i].TotalPrice+","+Operation.bookingList[i].DateBooked.ToShortDateString()+","+Operation.bookingList[i].BookingStatus;
            }
            File.WriteAllLines("Hotel/Booking.csv",BookingDetails);



        }
    }
}