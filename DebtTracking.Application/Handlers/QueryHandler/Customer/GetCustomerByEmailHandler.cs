using DebtTracking.Application.Queries.Customer;
using MediatR;

namespace DebtTracking.Application.Handlers.QueryHandler.Customer
{
    public class GetCustomerByEmailHandler : IRequestHandler<GetCustomerByEmailQuery, Core.Entities.Customer>
    {
        private readonly IMediator _mediator;

        public GetCustomerByEmailHandler(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task<Core.Entities.Customer> Handle(GetCustomerByEmailQuery request, CancellationToken cancellationToken)
        {
            var customers = await _mediator.Send(new GetAllCustomerQuery());
            var selectedCustomer = customers.FirstOrDefault(x => x.Email.ToLower().Contains(request.Email.ToLower()));
            return selectedCustomer;
        }
    }
}
