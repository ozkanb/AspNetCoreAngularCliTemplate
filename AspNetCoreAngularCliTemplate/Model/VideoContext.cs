using Microsoft.EntityFrameworkCore;

namespace AspNetCoreAngularCliTemplate.Model
{
    public class VideoContext : DbContext
    {
        public VideoContext(DbContextOptions<VideoContext> options) : base(options)
        {

        }

        public DbSet<Video> Videos { get; set; }
    }
}