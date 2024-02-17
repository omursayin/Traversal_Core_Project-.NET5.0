using Microsoft.EntityFrameworkCore;

namespace SignalRApiForSql.DataAccessLayer
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<Visitor> Visitors { get; set; }
    }
}
