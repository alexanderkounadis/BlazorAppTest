using BlazorApp.Shared;

namespace BlazorApp.Client.Services.CustomerService
{
    public interface ICustomerService
    {
        List<Customer> Customers { get; set; }
        Task GetCustomers();
        Task<Customer?> GetCustomerById(Guid id);
        Task CreateCustomer(Customer customer);
        Task UpdateCustomer(Guid id, Customer customer);
        Task DeleteCustomer(Guid id);
    }
}
