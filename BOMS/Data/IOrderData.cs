using BOMS.Models;

namespace BOMS.Data
{
    public interface IOrderData
    {
        Task<List<Order>> GetAllOrders();
        Task<List<LineItem>> GetLineitems(Order o);
        Task<List<Order>> GetOrder(Order o);
        Task UpsertOrder(Order data);
        Task InsertOrder(Order data);

        Task UpsertBook(Book data);

        Task InsertLineItem(int oId, int bId);
    }
}