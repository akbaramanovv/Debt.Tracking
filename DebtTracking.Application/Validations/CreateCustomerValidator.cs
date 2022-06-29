using DebtTracking.Application.Commands.Customer;
using DebtTracking.Core.Constants;
using FluentValidation;

namespace DebtTracking.Application.Validations
{
    public class CreateCustomerValidator : AbstractValidator<CreateCustomerCommand>
    {
        public CreateCustomerValidator()
        {
            RuleFor(c => c.FirstName).NotNull().WithMessage(Messages.FirstNameCanNotBeNull);
            RuleFor(c => c.FirstName).NotEmpty().WithMessage(Messages.FirstNameCanNotBeEmpty);
        }
    }
}
