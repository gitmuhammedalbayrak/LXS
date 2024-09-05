using LibX.Components.Model;
using Microsoft.EntityFrameworkCore;

namespace LibX.Data
{
    public class BookDbContext : DbContext
    {
        public BookDbContext(DbContextOptions<BookDbContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }

        // OnModelCreating yöntemi ile EstimatedValue için doğru decimal türünü ayarlıyoruz
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // 'EstimatedValue' için Decimal türü ayarı: 18 toplam hane, 2 ondalık hane
            modelBuilder.Entity<Book>()
                .Property(b => b.EstimatedValue)
                .HasColumnType("decimal(18,2)");
        }
    }
}
