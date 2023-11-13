using Dapper;
using BOMS.Models;
using System.Data;

namespace BOMS.Data
{
    public class OrderData
    {
        private readonly ISqlDataAccess _sql;

        public OrderData(ISqlDataAccess sql)
        {
            _sql = sql;
        }

        public async Task UpsertOrder(Order data) 
        { 
            DynamicParameters p = new DynamicParameters();
            p.Add("@OrderId", dbType: System.Data.DbType.Int32, direction: System.Data.ParameterDirection.Output );
            p.Add("@Date", data.Date);
            p.Add("@Outstanding", data.Outstanding);
            await _sql.SaveCustomerData("dbo.spOrder_Upsert", p);
            
        }

        public async Task<List<Order>> GetAllOrders()
        {         
            var results = await _sql.LoadOrderData("dbo.spOrder_GetAll", new DynamicParameters { });
            return results.ToList();
        }

        public  async Task<List<Order>> GetOrder(Order o)
        {     
            DynamicParameters p = new();
            p.Add("@OrderId", o.Id);
            var results = await _sql.LoadOrderData("dbo.spOrder_Get", p);
            return results.ToList();

        }
    }
}
