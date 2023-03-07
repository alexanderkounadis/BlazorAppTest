using BlazorApp.Shared;
using Microsoft.AspNetCore.Components;
using System.Net;
using System.Net.Http.Json;

namespace BlazorApp.Client.Services.CustomerService
{
    public class CustomerService : ICustomerService
    {
        private readonly HttpClient _http;
        private readonly NavigationManager _navigationManger;

        public CustomerService(HttpClient http, NavigationManager navigationManger)
        {
            _http = http;
            _navigationManger = navigationManger;
        }

        public List<Customer> Customers { get; set; } = new List<Customer>();

        public async Task CreateCustomer(Customer customer)
        {
            await _http.PostAsJsonAsync("api/customer", customer);
            _navigationManger.NavigateTo("customers");
        }

        public async Task DeleteCustomer(Guid id)
        {
            var result = await _http.DeleteAsync($"api/customer/{id}");
            _navigationManger.NavigateTo("customers");
        }

        public async Task<Customer?> GetCustomerById(Guid id)
        {
            var result = await _http.GetAsync($"api/customer/{id}");
            if (result.StatusCode == HttpStatusCode.OK)
            {
                return await result.Content.ReadFromJsonAsync<Customer>();
            }
            return null;
        }

        public async Task GetCustomers()
        {
            var result = await _http.GetFromJsonAsync<List<Customer>>("api/customer");
            if (result is not null)
                Customers = result;
        }

        public async Task UpdateCustomer(Guid id, Customer customer)
        {
            await _http.PutAsJsonAsync($"api/customer/{id}", customer);
            _navigationManger.NavigateTo("customers");
        }
    }
}
