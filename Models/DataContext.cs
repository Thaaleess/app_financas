using Microsoft.EntityFrameworkCore;

namespace app_financas.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) :base(options)
        {
            
        }

        public DbSet<Financas> financas { get; set; }
    }
}