using Microsoft.EntityFrameworkCore;
using  Laba_3_my.Models;


namespace Laba_3_my.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            // Database.EnsureDeleted();
            //Database.EnsureCreated();
        }
        public DbSet<Brend> Brend { get; set; }
        public DbSet<Year> Year { get; set; }
        public DbSet<Telephone> Telephone { get; set; }
        public DbSet<Owner> Owner { get; set; }
        //public DbSet<Laba_3_my.Models.Brend> Brend { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Year>().ToTable("Year");
        //    modelBuilder.Entity<Film>().ToTable("Films");
        //    modelBuilder.Entity<Genre>().ToTable("Genre");
        //    //modelBuilder.Entity<Producer>().ToTable("Producers");
        //}
        //public DbSet<oop3.Models.Genre> Genre { get; set; } = default!;
    }
}