using Microsoft.EntityFrameworkCore;
using NouApi.Models;

namespace NouApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> opt) : base(opt)
        {

        }

        public DbSet<Message> Messages { get; set; }
    }
}
