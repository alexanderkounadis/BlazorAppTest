using BlazorApp.Server.Services.CustomerService;

using BlazorApp.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public async Task<List<Customer>> GetCustomers()
        {
            return await _customerService.GetCustomers();
        }

        [HttpGet("{id}")]
        public async Task<Customer?> GetCustomerById(Guid id)
        {
            return await _customerService.GetCustomerById(id);
        }

        [HttpPost]
        public async Task<Customer?> CreateCustomer(Customer customer)
        {
            return await _customerService.CreateCustomer(customer);
        }

        [HttpPut("{id}")]
        public async Task<Customer?> UpdateCustomer(Guid id, Customer customer)
        {
            return await _customerService.UpdateCustomer(id, customer);
        }

        [HttpDelete("{id}")]
        public async Task<bool> DeleteCustomer(Guid id)
        {
            return await _customerService.DeleteCustomer(id);
        }
    }
}