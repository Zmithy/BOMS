using Dapper;
using BOMS.Models;
using System.Data;

namespace BOMS.Data
{
    public class OrderData : IOrderData
    {
        private readonly ISqlDataAccess _sql;

        public OrderData(ISqlDataAccess sql)
        {
            _sql = sql;
        }

        public async Task UpsertBook(Book data)
        {
            DynamicParameters p = new DynamicParameters();
            p.Add("@Title", data.Title);
            p.Add("@Price", data.Price);
            p.Add("@ISBN", data.ISBN);
            p.Add("@Notes", data.Notes);
            await _sql.SaveBookData("dbo.spBookUpsert", p);
        }

        public async Task UpsertOrder(Order data)
        {
            DynamicParameters p = new DynamicParameters();
            p.Add("@OrderId", dbType: System.Data.DbType.Int32, direction: System.Data.ParameterDirection.Output);
            p.Add("@DateCreated", data.DateCreated);
            p.Add("@Outstanding", data.Outstanding);
            await _sql.SaveCustomerData("dbo.spOrder_Upsert", p);

        }
        public async Task InsertOrder(Order data)
        {
            DynamicParameters p = new DynamicParameters();
            p.Add("@Outstanding", data.Outstanding);
            p.Add("@Customer_Id", data.CustomerId);
            p.Add("@Discount", data.Discount);
            await _sql.SaveOrderData("dbo.spLineItem_Insert", p);
        }
        public async Task InsertLineItem(int oId, int bId)
        {
            DynamicParameters p = new DynamicParameters();
            p.Add("@Order", oId);
            p.Add("@Book_Id", bId);
           
            await _sql.SaveOrderData("dbo.spOrder_Insert", p);
        }

        public async Task<List<Order>> GetAllOrders()
        {
            var results = await _sql.LoadOrderData("dbo.spOrder_GetAll", new DynamicParameters { });
            return results.ToList();
        }

        public async Task<List<OrderSummary>> GetOrderSummaries()
        {
            var results = await _sql.LoadOrderSummaries("dbo.spOrder_GetSummary", new DynamicParameters { });
            return results.ToList();
        }
        public async Task<List<Book>> GetBook(Book b)
        {
            DynamicParameters p = new DynamicParameters();
            p.Add("@ISBN", b.ISBN);
            var results = await _sql.LoadBookData("dbo.spBook_Get", p);
            return results.ToList();
        }

        public async Task<List<Order>> GetOrder(Order o)
        {
            DynamicParameters p = new();
            p.Add("@Order_Id", o.Id);
            var results = await _sql.LoadOrderData("dbo.spOrder_Get", p);
            return results.ToList();

        }

        public async Task<List<LineItem>> GetLineitems(Order o)
        {
            DynamicParameters p = new DynamicParameters();
            p.Add("@Order_Id", o.Id);
            var results = await _sql.LoadLineItemData("dbo.spLineItems_Get", p);
            return results.ToList();
        }

       
    }
}
