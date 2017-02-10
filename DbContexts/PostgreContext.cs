using Microsoft.EntityFrameworkCore;

namespace Biscuit.DbContexts
{
    public class PostgreContext : DbContext
    {
        public PostgreContext(DbContextOptions<PostgreContext> options) : base(options)
        {
        }

        public DbSet<Models.Core.Tenant> Tenants {get;set;}
    }
}