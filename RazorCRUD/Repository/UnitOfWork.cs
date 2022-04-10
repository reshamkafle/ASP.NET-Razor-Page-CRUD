using RazorCRUD.Data;
using RazorCRUD.Interfaces;

namespace RazorCRUD.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CustomerDBContext _context;
        public ICustomerRepository Customer { get; set; }
        public UnitOfWork(
        CustomerDBContext context
        )
        {
            _context = context;
            Customer = new CustomerRepository(_context);
        }
        public async Task<int> CompletedAsync()
        {
            return await _context.SaveChangesAsync();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
