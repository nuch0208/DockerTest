using Demoapp.Model;
using Microsoft.EntityFrameworkCore;

namespace Demoapp.Data;
public class ApiDbContext : DbContext
{
    public ApiDbContext(DbContextOptions<ApiDbContext> options)
        : base(options)
        {

        }
        public DbSet<Driver>  Drives { get; set; }
}