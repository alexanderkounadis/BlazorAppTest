using BlazorApp.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=IND-L-PF3NKXGV\\SQLEXPRESS;Initial Catalog=CustomerDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
                    new Customer
                    {
                        Id = Guid.NewGuid(),
                        ContactName = "Andrew McDonald",
                        Phone = "123-45678",
                        CompanyName = "Microsoft",
                        Address = "Oxford str",
                        City= "London",
                        PostalCode = "12345",
                        Country = "UK",
                        Region= "West"
                    },
                    new Customer
                    {
                        Id = Guid.NewGuid(),
                        ContactName = "Chris Konor",
                        Phone = "123-45678",
                        CompanyName = "Oracle",
                        Address = "Wisconsin str",
                        City = "Madison",
                        PostalCode = "12345",
                        Country = "USA",
                        Region = "Milwaukee"
                    },
                    new Customer
                    {
                        Id = Guid.NewGuid(),
                        ContactName = "George Papanikos",
                        Phone = "123-45678",
                        CompanyName = "Epsilon",
                        Address = "Ag Georgiou 45",
                        City = "Patras",
                        PostalCode = "12345",
                        Country = "Greece",
                        Region = "West"
                    },
                    new Customer
                    {
                        Id = Guid.NewGuid(),
                        ContactName = "Irene Hunt",
                        Phone = "123-45678",
                        CompanyName = "Mars",
                        Address = "King str",
                        City = "NY",
                        PostalCode = "12345",
                        Country = "USA",
                        Region = "NY"
                    });

        }

        public DbSet<Customer> Customers => Set<Customer>();
    }
}
