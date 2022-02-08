using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using yenitemplate.Models;

namespace yenitemplate.Context
{
    public class MyDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=VizeProje;MultipleActiveResultSets=true");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GuestResponse>().HasKey("email");//vt da hangi alanın birincil olduğunu işaretledik.
            //fluent Api kullanmış olduk.
        }

        public DbSet<GuestResponse> GuestResponses { get; set; }
    }
}

