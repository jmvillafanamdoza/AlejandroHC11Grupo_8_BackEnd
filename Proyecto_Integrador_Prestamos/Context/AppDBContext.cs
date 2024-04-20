using Microsoft.EntityFrameworkCore;
using Proyecto_Integrador_Prestamos.Models;

namespace Proyecto_Integrador_Prestamos.Context
{
    public class AppDBContext :DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext>options):base(options) 
        {
            
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("users");
        }
    }
}
