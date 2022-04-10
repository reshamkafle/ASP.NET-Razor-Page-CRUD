using Microsoft.EntityFrameworkCore;
using RazorCRUD.Models;

namespace RazorCRUD.Data
{
    public class CustomerDBContext : DbContext
    {
        public CustomerDBContext(DbContextOptions<CustomerDBContext> options) : base(options)
        {
        }
        public DbSet<Customer> Customer { get; set; }   
    }
}
