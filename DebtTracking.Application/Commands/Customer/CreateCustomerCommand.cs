using DebtTracking.Application.Response.Customer;
using MediatR;
namespace DebtTracking.Application.Commands.Customer
{
    public  class CreateCustomerCommand: IRequest<CustomerResponse>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }
        public DateTime CreatedDate { get; set; }

        public CreateCustomerCommand()
        {
            this.CreatedDate = DateTime.Now;
        }
    }
}
