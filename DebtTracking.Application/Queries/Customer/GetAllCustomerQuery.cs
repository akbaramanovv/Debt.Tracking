using MediatR;
namespace DebtTracking.Application.Queries.Customer
{
    public class GetAllCustomerQuery :IRequest<List<Core.Entities.Customer>>
    {
    }
}
