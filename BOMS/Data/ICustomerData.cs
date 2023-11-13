using BOMS.Models;

namespace BOMS.Data
{
    public interface ICustomerData
    {
        Task UpsertCustomer(Customer data);
        Task<List<Customer>> GetAllCustomers();
        Task<List<Customer>> GetCustomer(Customer c);
    }
}