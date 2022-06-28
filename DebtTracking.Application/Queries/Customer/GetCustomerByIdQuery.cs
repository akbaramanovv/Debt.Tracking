using MediatR;

namespace DebtTracking.Application.Queries.Customer
{
    public class GetCustomerByIdQuery : IRequest<Core.Entities.Customer>
    {
        public Int64 Id { get; private set; }

        public GetCustomerByIdQuery(Int64 Id)
        {
            this.Id = Id;
        }
    }
}
