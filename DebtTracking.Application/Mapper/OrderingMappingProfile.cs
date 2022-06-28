using AutoMapper;
using DebtTracking.Application.Commands;
using DebtTracking.Application.Commands.Customer;
using DebtTracking.Application.Response.Customer;
using DebtTracking.Core.Entities;

namespace DebtTracking.Application.Mapper
{
    internal class OrderingMappingProfile: Profile
    {
        public OrderingMappingProfile()
        {
            CreateMap<Customer, CustomerResponse>().ReverseMap();
            CreateMap<Customer, CreateCustomerCommand>().ReverseMap();
            CreateMap<Customer, EditCustomerCommand>().ReverseMap();
        }
    }
}
