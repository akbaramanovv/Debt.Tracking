using DebtTracking.Application.Queries.Customer;
using MediatR;

namespace DebtTracking.Application.Handlers.QueryHandler.Customer
{
    public class GetCustomerByIdHandler: IRequestHandler<GetCustomerByIdQuery, Core.Entities.Customer>
    {
        private readonly IMediator _mediator;

        public GetCustomerByIdHandler(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task<Core.Entities.Customer> Handle(GetCustomerByIdQuery request, CancellationToken cancellationToken)
        {
            var customers = await _mediator.Send(new GetAllCustomerQuery());
            var selectedCustomer = customers.FirstOrDefault(x => x.Id == request.Id);
            return selectedCustomer;
        }
    }
}
