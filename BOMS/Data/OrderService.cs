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
            var number = rand.Next(100);
            while (number >= 0) 
            {
                var c = Customer.GenerateRandomCustomer();
                if (number > 50) tf = true;
                else tf = false;
               
                orders.Add(new Order()
                {
                     Id = rand.Next(number),
                     Date = DateTime.Now.AddDays(-1 * number),
                     Customer = c,
                     Outstanding = tf
                });
                number--;
            }

            return Task.FromResult(orders);
        }
    }
}
