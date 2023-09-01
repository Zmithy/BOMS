using BOMS.Models;

namespace BOMS.Data
{
    // Not Currently Implemented, Sample Data
    public class OrderService
    {
        // Returns Sample data 
        public  Task<List<Order>> GetOrdersAsync()
        {
            List<Order> orders = new();
            
            bool tf; ;
            var rand = new Random();
            var number = rand.Next(12);
            while (number >= 0) 
            {
                var c = Customer.GetRCustomer();
                if (number % 2 == 0) tf = true;
                else tf = false;
               
                orders.Add(new Order()
                {
                     Id = rand.Next(number),
                     Date = DateOnly.FromDateTime(DateTime.Now),
                     Customer = c,
                     Outstanding = tf
                });
                number--;
            }

            return Task.FromResult(orders);
        }
    }
}
