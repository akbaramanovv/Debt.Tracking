using DebtTracking.Core.Repositories.Command;
using DebtTracking.Infrastrucuture.Data.Context;

namespace DebtTracking.Infrastrucuture.Repository.Command.Base
{
    public class CustomerCommandRepository: CommandRepository<Customer>, ICustomerCommandRepository
    {
        public CustomerCommandRepository(DebtTrackingContext context) : base(context)
        {

        }

        public Task<Core.Entities.Customer> AddAsync(Core.Entities.Customer entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Core.Entities.Customer entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Core.Entities.Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
