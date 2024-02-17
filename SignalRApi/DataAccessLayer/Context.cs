using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Security.Cryptography.X509Certificates;

namespace SignalRApi.DataAccessLayer
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
            
        }

        public DbSet<Visitor> Visitors { get; set; }
    }
}
