using Microsoft.EntityFrameworkCore;
using TuneTracks.Models;
namespace TuneTracks.Data
{
    public class TuneTracksContext : DbContext
    {
        public TuneTracksContext(DbContextOptions<TuneTracksContext> options) : base(options)
        {
        }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Song> Songs { get; set; }
    }
}