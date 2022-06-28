using DebtTracking.Core.Entities;
using DebtTracking.Core.Repositories.Query.Base;

namespace DebtTracking.Core.Repositories.Query
{
    public interface ICustomerQueryRepository: IQueryRepository<Customer>
    {
        //Custom operation which is not generic
        Task<IReadOnlyList<Customer>> GetAllAsync();
        Task<Customer> GetByIdAsync(Int64 id);
        Task<Customer> GetCustomerByEmail(string email);
    }
}
