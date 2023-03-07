using BlazorApp.Server.Data;
using BlazorApp.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Server.Services.CustomerService
{
    public class CustomerService : ICustomerService
    {
        private readonly DataContext _context;

        public CustomerService(DataContext context)
        {
            _context = context;
        }

        public async Task<Customer> CreateCustomer(Customer customer)
        {
            _context.Add(customer);
            await _context.SaveChangesAsync();
            return customer;
        }

        public async Task<bool> DeleteCustomer(Guid customerId)
        {
            var dbCustomer = await _context.Customers.FindAsync(customerId);
            if (dbCustomer == null)
            {
                return false;
            }

            _context.Remove(dbCustomer);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<Customer?> GetCustomerById(Guid CustomerId)
        {
            var dbCustomer = await _context.Customers.FindAsync(CustomerId);
            return dbCustomer;
        }

        public async Task<List<Customer>> GetCustomers()
        {
            return await _context.Customers.ToListAsync();
        }

        public async Task<Customer?> UpdateCustomer(Guid CustomerId, Customer Customer)
        {
            var dbCustomer = await _context.Customers.FindAsync(CustomerId);
            if (dbCustomer != null)
            {
                dbCustomer.Address = Customer.Address;
                dbCustomer.ContactName = Customer.ContactName;
                dbCustomer.CompanyName = Customer.CompanyName;
                dbCustomer.Phone = Customer.Phone;
                dbCustomer.City = Customer.City;
                dbCustomer.Region = Customer.Region;
                dbCustomer.Phone = Customer.Phone;
                dbCustomer.Country = Customer.Country;

                await _context.SaveChangesAsync();
            }

            return dbCustomer;
        }
    }
}
