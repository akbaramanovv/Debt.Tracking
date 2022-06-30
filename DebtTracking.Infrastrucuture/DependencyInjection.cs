using DebtTracking.Core.Repositories.Command;
using DebtTracking.Core.Repositories.Command.Base;
using DebtTracking.Core.Repositories.Query;
using DebtTracking.Core.Repositories.Query.Base;
using DebtTracking.Infrastrucuture.Data.Context;
using DebtTracking.Infrastrucuture.Repository.Command.Base;
using DebtTracking.Infrastrucuture.Repository.Query;
using DebtTracking.Infrastrucuture.Repository.Query.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
namespace DebtTracking.Infrastrucuture
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DebtTrackingContext>(options =>
            {
                options.UseSqlite(configuration.GetConnectionString("DefaultConnection"));
                options.UseSqlServer(configuration.GetConnectionString("ConnectionWithTiberium"));
            });
            services.AddTransient(typeof(IQueryRepository<>), typeof(QueryRepository<>));
            services.AddTransient<ICustomerQueryRepository, CustomerQueryRepository>();
            services.AddScoped(typeof(ICommandRepository<>), typeof(CommandRepository<>));
            services.AddTransient<ICustomerCommandRepository, CustomerCommandRepository>();

            return services;
        }
    }
}
