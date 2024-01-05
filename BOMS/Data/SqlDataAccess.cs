using BOMS.Models;
using Dapper;
using System.Data;
using System.Data.SqlClient;
namespace BOMS.Data
{
    public class SqlDataAccess : ISqlDataAccess
    {
        private readonly IConfiguration _config;

        public SqlDataAccess(IConfiguration config)
        {
            _config = config;
        }

       
        // Data Loads
        
        //      Customer
        public async Task<IEnumerable<Customer>> LoadCustomerData(string sql,
                                   DynamicParameters data,
                                   string connectionStringName = "Default")
        {
            using var conn = new SqlConnection(_config.GetConnectionString(connectionStringName));
           

            return await conn.QueryAsync<Customer>(sql, data, commandType: CommandType.StoredProcedure);
        }

        //      Order
        public async Task<IEnumerable<Order>> LoadOrderData(string sql,
                                                            DynamicParameters data,
                                                            string connectionStringName = "Default")
        {
            using var conn = new SqlConnection(_config.GetConnectionString(connectionStringName));
            return await conn.QueryAsync<Order>(sql, data, commandType: CommandType.StoredProcedure);
        }

        //      Book
        public async Task<IEnumerable<Book>> LoadBookData(string sql,
                                                          DynamicParameters data,
                                                          string connectionStringName = "Default")
        {
            using var conn = new SqlConnection(_config.GetConnectionString(connectionStringName));
            return await conn.QueryAsync <Book>(sql,data, commandType: CommandType.StoredProcedure);
        }

        //      LineItem
        public async Task<IEnumerable<LineItem>> LoadLineItemData(string sql,
                                                            DynamicParameters data,
                                                            string connectionStringName = "Default")
        {
            using var conn = new SqlConnection(_config.GetConnectionString(connectionStringName));
            return await conn.QueryAsync<LineItem>(sql, data, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<OrderSummary>> LoadOrderSummaries(string sql,
                                                                        DynamicParameters data, 
                                                                        string connectionStringName = "Default")
        {
            using var conn = new SqlConnection(_config.GetConnectionString(connectionStringName));
            return await conn.QueryAsync<OrderSummary>(sql,data,commandType: CommandType.StoredProcedure);
        }

        // Data Saves

        //      Customer
        public async Task SaveCustomerData(string sql,
                               DynamicParameters data,
                               string connectionStringName = "Default")
        {

            using var conn = new SqlConnection(_config.GetConnectionString(connectionStringName));
            // Don't need to await since there is no other access. Maybe? does that sound real?
            await conn.ExecuteAsync(sql,
                                     data,
                                     commandType: System.Data.CommandType.StoredProcedure);

        }

        //      Order
        public async Task SaveOrderData(string sql, DynamicParameters data, string connectionStringName = "Default")
        {
            using var conn = new SqlConnection(_config.GetConnectionString(connectionStringName));
            await conn.ExecuteAsync(sql,
                                     data,
                                     commandType: System.Data.CommandType.StoredProcedure);
        }

        //      Book
        public async Task SaveBookData(string sql, DynamicParameters data, string connectionStringName = "Default")
        {
            using var conn = new SqlConnection(_config.GetConnectionString(connectionStringName));
            await conn.ExecuteAsync(sql,
                                     data,
                                     commandType: System.Data.CommandType.StoredProcedure);
        }
    }
}
