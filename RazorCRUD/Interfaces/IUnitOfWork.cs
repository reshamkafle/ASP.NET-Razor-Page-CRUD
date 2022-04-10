namespace RazorCRUD.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ICustomerRepository Customer { get; }
        Task<int> CompletedAsync();
    }
}
