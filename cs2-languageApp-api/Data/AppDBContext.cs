using cs2_languageApp_api.Models;
using Microsoft.EntityFrameworkCore;

namespace cs2_languageApp_api.Data
{
    public class AppDBContext: DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options): base(options) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<German>().HasData(
                new German { Id=1, Word="krankenwagen", Translation="hospital"},
                new German { Id=2, Word="schwester", Translation="sister"});

            modelBuilder.Entity<Hungarian>().HasData(
                new Hungarian{Id=1, Word="bocsanot", Translation="sorry" },
                new Hungarian { Id=2, Word="Szia", Translation="hallo"});

            modelBuilder.Entity<English>().HasData(
                new English { Id=1, Word="car", Translation="auto"},
                new English { Id=2, Word="cube", Translation="kocka"});
        }

        public DbSet<German> german { get; set; }

        public DbSet<Hungarian> hungarian { get; set; }

        public DbSet<English> english { get; set; }
    }
}
