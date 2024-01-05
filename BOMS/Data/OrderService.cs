using BOMS.Models;

namespace BOMS.Data
{
    // Not Currently Implemented
    // -Current functionality of the order service is under Data.OrderData
    // TODO: Build to replace OrderData functions to meet naming conventions
    public class OrderService
    {
        //Returns Sample data
        public Task<List<Order>> GetOrdersAsync()
        {
            List<Order> orders = new();

            bool tf; ;
            var rand = new Random();
            var number = rand.Next(100);
            while (number >= 0)
            {
                if (number > 50) tf = true;
                else tf = false;

                orders.Add(new Order()
                {
                    Id = rand.Next(number),
                    DateCreated = DateTime.Now.AddDays(-1 * number),
                    CustomerId = 6,
                    Outstanding = tf
                });
                number--;
            }

            return Task.FromResult(orders);
        }



    }
}
