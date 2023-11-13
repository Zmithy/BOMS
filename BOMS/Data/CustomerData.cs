using BOMS.Models;
using Dapper;
using System.Data;

namespace BOMS.Data
{
    public class CustomerData : ICustomerData
    {
        private readonly ISqlDataAccess _sql;

        public CustomerData(ISqlDataAccess sql)
        {
            _sql = sql;
        }
        
        public async Task UpsertCustomer(Customer data)
        {

            DynamicParameters p = new();

            p.Add("@CustomerId", dbType: DbType.Int32, direction: ParameterDirection.Output);
            p.Add("@Name", data.Name);
            p.Add("Email", data.Email);
            p.Add("@Phone", data.Phone);
            p.Add("@City", data.City);
            p.Add("@Region", data.Region);
            p.Add("@PostalCode", data.PostalCode);
            await _sql.SaveCustomerData("dbo.spCustomer_Upsert", p);
        }

        public async Task<List<Customer>> GetAllCustomers()
        {
            //DynamicParameters p = new();
            //p.Add("@Customers", dbType: DbType.Int32, direction: ParameterDirection.Output);
            var results = await _sql.LoadCustomerData("dbo.spCustomer_GetAll", new DynamicParameters { });
            return results.ToList();
        }

        public async Task<List<Customer>> GetCustomer(Customer c)
        {
            DynamicParameters p = new();
            p.Add("@Email", c.Email);
            var results = await _sql.LoadCustomerData("dbo.spCustomer_Get", p);
            return results.ToList();

        }

    }
}
