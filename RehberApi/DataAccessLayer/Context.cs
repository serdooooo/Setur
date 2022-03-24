using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RehberApi.DataAccessLayer
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=PhoneDirectory;User Id=postgres;Password=1234;");
        }
        //public Context(DbContextOptions<Context> options) : base(options) { }
        public DbSet<Rehber> Rehbers { get; set; }
        public DbSet<Iletisim> Iletisims { get; set; }
    }
}
