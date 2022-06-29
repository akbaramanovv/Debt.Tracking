using DebtTracking.Application.Commands.Customer;
using DebtTracking.Application.Mapper;
using DebtTracking.Application.Response.Customer;
using DebtTracking.Core.Constants;
using DebtTracking.Core.Repositories.Command;
using FluentValidation;
using MediatR;
namespace DebtTracking.Application.Handlers.CommandHandler.Customer
{
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerCommand, CustomerResponse>
    {
        private readonly ICustomerCommandRepository _customerCommandRepository;
        private readonly IValidator<CreateCustomerCommand> _validator;

        public CreateCustomerHandler(ICustomerCommandRepository customerCommandRepository)
        {
            _customerCommandRepository = customerCommandRepository;

        }
        public async Task<CustomerResponse> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            _validator.Validate(request);

            var customerEntity = CustomerMapper.Mapper.Map<Core.Entities.Customer>(request);

            if (customerEntity is null)
            {
                throw new ApplicationException(Messages.MapperGeneralErr);
            }

            var newCustomer = await _customerCommandRepository.AddAsync(customerEntity);
            var customerResponse = CustomerMapper.Mapper.Map<CustomerResponse>(newCustomer);
            return customerResponse;
        }
    }
}
