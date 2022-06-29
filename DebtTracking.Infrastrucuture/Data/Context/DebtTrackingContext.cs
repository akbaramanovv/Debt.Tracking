using Microsoft.EntityFrameworkCore;

namespace DebtTracking.Infrastrucuture.Data.Context
{
    public partial class DebtTrackingContext : DbContext
    {
        public DebtTrackingContext()
        {
        }

        public DebtTrackingContext(DbContextOptions<DebtTrackingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Test> Tests { get; set; } = null!;
        public virtual DbSet<Test2> Test2s { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Data Source=172.18.102.22,1535;Initial Catalog=Lisi;Persist Security Info=True;User ID=sa_lisi;Password=oavshetrix");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Test>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("test", "dt");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .HasColumnName("id")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Test2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("test2", "dt");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .HasColumnName("id")
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
