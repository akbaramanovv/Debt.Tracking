using MediatR;

namespace DebtTracking.Application.Queries.Customer
{
    public class GetCustomerByEmailQuery : IRequest<Core.Entities.Customer>
    {
        public string Email { get; private set; }

        public GetCustomerByEmailQuery(string email)
        {
            this.Email = email;
        }
    }
}
