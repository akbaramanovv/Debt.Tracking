using DebtTracking.Core.Repositories.Command;
using DebtTracking.Infrastrucuture.Data.Context;

namespace DebtTracking.Infrastrucuture.Repository.Command.Base
{
    public class CustomerCommandRepository: CommandRepository<Core.Entities.Customer>, ICustomerCommandRepository
    {
        public CustomerCommandRepository(DebtTrackingContext context) : base(context)
        {

        }
    }
}
