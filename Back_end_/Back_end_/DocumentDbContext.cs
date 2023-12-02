using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Back_end_.Models;

namespace Back_end_
{
    public class DocumentDbContext : IdentityDbContext
    {
        public DocumentDbContext(DbContextOptions<DocumentDbContext> options) : base(options)
        {
        }

        public DbSet<Documents> Documents { get; set; }

        public DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-RSERD5R\\SQLEXPRESS; initial catalog=Back_end_; Integrated Security=true;TrustServerCertificate=Yes;");
        }
    }
}
