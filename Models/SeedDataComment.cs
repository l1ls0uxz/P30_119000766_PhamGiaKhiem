using Microsoft.EntityFrameworkCore;

namespace RazorPagesMovie.Models
{
    public static class SeedDataComment
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesMovieContext>>()))
            {
                if (context == null || context.Comment == null)
                {
                    throw new ArgumentNullException("Null RazorPagesMovieContext");
                }

                // Look for any movies.
                if (context.Comment.Any())
                {
                    return;   // DB has been seeded
                }

                context.Comment.AddRange(
                    new Comment
                    {
                       ID = 1,
                       Author = "Pham Pham 1",
                       Content ="Conntent 1",
                       CreatedAt ="CreatedAt 1"
                    },

                    new Comment
                    {
                        ID =2,
                       Author = "Pham Pham 2",
                       Content ="Conntent 2",
                       CreatedAt ="CreatedAt 2"
                    },

                    new Comment
                    {
                        ID = 3,
                       Author = "Pham Pham 3",
                       Content ="Conntent 3",
                       CreatedAt ="CreatedAt 3"
                    },

                    new Comment
                    {
                        ID = 4,
                       Author = "Pham 4",
                       Content ="Conntent 4",
                       CreatedAt ="CreatedAt 4"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}

