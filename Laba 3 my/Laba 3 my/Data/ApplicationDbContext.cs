using Microsoft.EntityFrameworkCore;
//using  Laba_3_my.Data;
//using  Laba_3_my.Models;


namespace Laba_3_my.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<Year> Year { get; set; }
        public DbSet<Telephone> Telephone { get; set; }
        public DbSet<Owner> Owner { get; set; }
      
    }
}