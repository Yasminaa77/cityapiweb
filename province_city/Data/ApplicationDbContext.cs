using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using province_city.Models;

namespace province_city.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder){
            base.OnModelCreating(builder);
            //is required & max length  for the provinvce name Min 16

            builder.Entity<Province>().ToTable("Province");
            builder.Entity<City>().ToTable("City");


            builder.Seed();

        }


        public DbSet<Province> Provinces { get; set; }
        public DbSet<City> Cities { get; set; }
    }
}