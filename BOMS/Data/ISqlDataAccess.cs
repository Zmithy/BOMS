using BOMS.Models;
using Dapper;

namespace BOMS.Data
{
    public interface ISqlDataAccess
    {
        Task SaveCustomerData(string sql, DynamicParameters data, string connectionStringName = "Default");
        Task<IEnumerable<Customer>> LoadCustomerData(string sql, DynamicParameters data, string connectionStringName ="Default");

        Task<IEnumerable<Order>> LoadOrderData(string sql, DynamicParameters data, string connectionStringName = "Default");
        Task SaveOrderData(string sql, DynamicParameters data, string connectionStringName = "Default");

        Task<IEnumerable<Book>> LoadBookData(string sql, DynamicParameters data, string connectionStringName = "Default");
        Task SaveBookData(string sql, DynamicParameters data, string connectionStringName = "Default");


    }
}
