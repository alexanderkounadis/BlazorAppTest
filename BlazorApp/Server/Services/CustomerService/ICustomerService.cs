using BlazorApp.Shared;

namespace BlazorApp.Server.Services.CustomerService
{
    public interface ICustomerService
    {
        Task<List<Customer>> GetCustomers();
        Task<Customer?> GetCustomerById(Guid customerId);
        Task<Customer> CreateCustomer(Customer customer);
        Task<Customer?> UpdateCustomer(Guid customerId, Customer customer);
        Task<bool> DeleteCustomer(Guid customerId);
    }
}
