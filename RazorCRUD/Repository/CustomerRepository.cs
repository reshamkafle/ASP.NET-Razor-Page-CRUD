using RazorCRUD.Data;
using RazorCRUD.Interfaces;
using RazorCRUD.Models;

namespace RazorCRUD.Repository
{

    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(CustomerDBContext context) : base(context)
        {
        }
    }
}
