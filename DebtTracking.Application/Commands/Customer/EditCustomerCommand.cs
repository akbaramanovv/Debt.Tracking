﻿using DebtTracking.Application.Response.Customer;
using MediatR;

namespace DebtTracking.Application.Commands.Customer
{
    public class EditCustomerCommand: IRequest<CustomerResponse>
    {
        public Int64 Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }
    }
}
