using DebtTracking.Application.Handlers.CommandHandler.Customer;
using DebtTracking.Application.Validations;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace DebtTracking.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(typeof(CreateCustomerHandler).GetTypeInfo().Assembly);
            services.AddTransient<CreateCustomerValidator>();
            return services;
        }
    }
}
