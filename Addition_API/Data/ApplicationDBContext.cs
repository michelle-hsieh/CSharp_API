using Addition_API.Data;

using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Addition_API.Data
{
    public class ApplicationDBContext : DbContext
    {
        // Constructor
        public ApplicationDBContext(DbContextOptions options) : base(options)
        {
        }

        // Public properties
        public DbSet<Dept> Dept { get; set; }

        // Overriden methods
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // 這段沒看懂???
            modelBuilder.Entity<Dept>().HasData(GetDepts());
            base.OnModelCreating(modelBuilder);
        }

        // Private methods
        private List<Dept> GetDepts()
        {
            return new List<Dept>
            {
                new Dept { deptid = 1, dname = "壽險資訊部", location = "台北市" },
                new Dept { deptid = 2, dname = "數位資訊部", location = "松山區" },
                new Dept { deptid = 3, dname = "投資資訊部", location = "南京三民" }
            };
        }
    }
}