using DebtTracking.Core.Entities;
using DebtTracking.Core.Repositories.Command.Base;

namespace DebtTracking.Core.Repositories.Command
{
    public interface ICustomerCommandRepository : ICommandRepository<Customer>
    {
    }
}
