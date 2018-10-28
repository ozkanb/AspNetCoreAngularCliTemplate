using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace AspNetCoreAngularCliTemplate.Model
{
  public class VideoContextFactory : IDesignTimeDbContextFactory<VideoContext>
  {
    public VideoContext CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
      var optionsBuilder = new DbContextOptionsBuilder<VideoContext>();
      optionsBuilder.UseSqlServer(configuration.GetConnectionString("VideoContext"));

      return new VideoContext(optionsBuilder.Options);
    }
  }
}