using Addition_API.Model;

using Microsoft.EntityFrameworkCore;

namespace Addition_API.DAL
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Depts> Dept { get; set; }
        public ApplicationDBContext(DbContextOptions options) : base(options)
        {
        }
    }
}