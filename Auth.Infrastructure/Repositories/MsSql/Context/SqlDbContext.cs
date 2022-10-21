using Auth.Domain;
using Auth.Infrastructure.Repositories.MsSql.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Auth.Infrastructure.Repositories.MsSql.Context
{
    public class SqlDbContext : DbContext
    {
        public DbSet<User> User { get; set; }

        public SqlDbContext(DbContextOptions<SqlDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
           
            builder.ApplyConfiguration(new UserConfig());

        }
    }
}
