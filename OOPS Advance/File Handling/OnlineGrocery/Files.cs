using System.IO;

namespace OnlineGrocery
{
    public static class Files
    {
        public static void CreateFile()
        {
            if(!Directory.Exists("GroceryShop"))
            {
                Directory.CreateDirectory("GroceryShop");

            }
            if(!File.Exists("GroceryShop/Customer.csv"))
            {
                File.Create("GroceryShop/Customer.csv");

            }

            if(!File.Exists("GroceryShop/Product.csv"))
            {
               File.Create("GroceryShop/Product.csv");
            }

             if(!File.Exists("GroceryShop/order.csv"))
            {
               File.Create("GroceryShop/order.csv");
            }

             if(!File.Exists("GroceryShop/Booking.csv"))
            {
               File.Create("GroceryShop/Booking.csv");
            }

        }

        public static void ReadFiles()
        {
            string[] customer1=File.ReadAllLines("GroceryShop/Customer.csv");

            foreach (string customer in customer1)
            {
                CustomerDetails customer2=new CustomerDetails(customer);
                Operation.customerList.Add(customer2);
                
            }

            string[] product1=File.ReadAllLines("GroceryShop/Product.csv");
            foreach (string product in product1)
            {
                ProductDetails product2=new ProductDetails(product);
                Operation.ProductList.Add(product2);
            }

            string[] order1=File.ReadAllLines("GroceryShop/order.csv");
            foreach (string order in order1)
            {
                OrderDetails order2=new OrderDetails(order);
                Operation.orderList.Add(order2);
            }

            string[] book1=File.ReadAllLines("GroceryShop/Booking.csv");

            foreach (string book in book1)
            {
                BookingClass book2=new BookingClass(book);
                Operation.bookinglist.Add(book2);
            }

            
        }
        
        public static void WriteFiles()
        {
            string[] customerDetails=new string[Operation.customerList.Count];

            for (int i = 0; i < Operation.customerList.Count; i++)
            {
                customerDetails[i]=Operation.customerList[i].CustomerId+","+Operation.customerList[i].Name+","+Operation.customerList[i].FatherName+","+Operation.customerList[i].Gender+","+Operation.customerList[i].MobileNumber+","+Operation.customerList[i].DOB.ToShortDateString()+","+Operation.customerList[i].MailId+","+Operation.customerList[i].WalletBalance;
            }
            File.WriteAllLines("GroceryShop/Customer.csv",customerDetails);

            string[] productDetails=new string[Operation.ProductList.Count];
            for (int i = 0; i < Operation.ProductList.Count; i++)
            {
                productDetails[i]=Operation.ProductList[i].ProductId+","+Operation.ProductList[i].ProductName+","+Operation.ProductList[i].AvailableQuantity+","+Operation.ProductList[i].Price;
            }
            File.WriteAllLines("GroceryShop/Product.csv",productDetails);

            string[] orderDetails=new string[Operation.orderList.Count];
            for (int i = 0; i < Operation.orderList.Count; i++)
            {
               orderDetails[i]=Operation.orderList[i].OrderId+","+ Operation.orderList[i].BookingId+","+ Operation.orderList[i].ProductId+","+ Operation.orderList[i].ProductCount+","+ Operation.orderList[i].OrderPrice;
            }
            File.WriteAllLines("GroceryShop/order.csv",orderDetails);

            string[] bookingClass=new string[Operation.bookinglist.Count];
            for (int i = 0; i < Operation.bookinglist.Count; i++)
            {
              bookingClass[i]=Operation.bookinglist[i].BookingId+","+ Operation.bookinglist[i].CustomerId+","+Operation.bookinglist[i].TotalPrice+","+ Operation.bookinglist[i].DateofBooking.ToShortDateString()+","+Operation.bookinglist[i].BookingStatus; 
            }
            File.WriteAllLines("GroceryShop/Booking.csv",bookingClass);
        }
    
    
    }
}