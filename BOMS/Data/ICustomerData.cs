using BOMS.Models;

namespace BOMS.Data
{
    public interface ICustomerData
    {
        Task UpsertCustomer(Customer data);
        Task<List<Customer>> GetAllCustomers();
        Task<Customer> GetCustomer(Customer c);
    }
}