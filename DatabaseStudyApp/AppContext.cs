using DatabaseStudyApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace DatabaseStudyApp
{
    public class AppContext : DbContext
    {
        public DbSet<Music> Musics { get; set; }
        public DbSet<MusicGroup> MusicGroups { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-PS8UI7T;Initial Catalog=musicgroupdb;Integrated Security=True");
        }
    }
}
