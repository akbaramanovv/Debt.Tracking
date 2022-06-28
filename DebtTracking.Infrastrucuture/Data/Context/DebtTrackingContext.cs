using Microsoft.EntityFrameworkCore;

namespace DebtTracking.Infrastrucuture.Data.Context
{
    public class DebtTrackingContext : DbContext
    {
        public DebtTrackingContext(DbContextOptions<DebtTrackingContext> options) : base(options)
        {

        }

        public DbSet<Core.Entities.Customer> Customers { get; set; }
    }
}
