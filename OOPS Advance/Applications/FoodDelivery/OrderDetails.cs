

namespace FoodDelivery
{
    public class OrderDetails
    {
        private static int s_orderId=100;

        public string OrderId { get; set; }

        public string BookingId { get; set; }

        public string FoodId { get; set; }

        public int PurchaseCount { get; set; }

        public int PriceofOrder { get; set; }

        public OrderDetails(string bookingId,string foodId,int purchaseCount,int priceofOrder)
        {
            s_orderId++;
            OrderId="OID"+s_orderId;
            BookingId=bookingId;
            FoodId=foodId;
            PurchaseCount=purchaseCount;
            PriceofOrder=priceofOrder;

        }

         public OrderDetails(string data)
        {
            string[] value=data.Split(',');
            s_orderId=int.Parse(value[0].Remove(0,3));
            OrderId=value[0];
            BookingId=value[1];
            FoodId=value[2];
            PurchaseCount=int.Parse(value[3]);
            PriceofOrder=int.Parse(value[4]);
            
        }
        
        
        
        
        
        
        
        
        
        
    }
}