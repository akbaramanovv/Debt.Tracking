using DebtTracking.Application.Queries.Customer;
using DebtTracking.Core.Repositories.Query;
using MediatR;

namespace DebtTracking.Application.Handlers.QueryHandler.Customer
{
    public class GetAllCustomerHandler : IRequestHandler<GetAllCustomerQuery, List<Core.Entities.Customer>>
    {
        private readonly ICustomerQueryRepository _customerQueryRepository;

        public GetAllCustomerHandler(ICustomerQueryRepository customerQueryRepository)
        {
            _customerQueryRepository = customerQueryRepository;
        }
        public async Task<List<Core.Entities.Customer>> Handle(GetAllCustomerQuery request, CancellationToken cancellationToken)
        {
            return (List<Core.Entities.Customer>)await _customerQueryRepository.GetAllAsync();
        }
    }
}
