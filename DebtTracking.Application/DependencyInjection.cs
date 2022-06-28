using DebtTracking.Application.Handlers.CommandHandler.Customer;
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
            return services;
        }
    }
}
