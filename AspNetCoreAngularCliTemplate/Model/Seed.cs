using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace AspNetCoreAngularCliTemplate.Model
{
    public class Seed
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new VideoContext(serviceProvider.GetRequiredService<DbContextOptions<VideoContext>>()))
            {
                if (context.Videos.Any())
                {
                    return;
                }

                context.Videos.AddRange(
                    new Video
                    {
                        Title = "Hans Zimmer - Dust (Interstellar Soundtrack)",
                        Link = "https://www.youtube.com/watch?v=-0_VuwvvS-k",
                        Genre = "Music",
                        Watched= true
                    },
                    new Video
                    {
                        Title = "But what *is* a Neural Network? | Deep learning, chapter 1",
                        Link = "https://www.youtube.com/watch?v=aircAruvnKk&t=7s",
                        Genre = "Tech",
                        Watched = true
                    }
                );
                
                context.SaveChanges();
            }
        }
    }
}