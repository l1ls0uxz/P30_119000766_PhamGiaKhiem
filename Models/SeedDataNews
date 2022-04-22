using Microsoft.EntityFrameworkCore;


namespace RazorPagesMovie.Models
{
    public static class SeedDataNews
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesMovieContext>>()))
            {
                if (context == null || context.News == null)
                {
                    throw new ArgumentNullException("Null RazorPagesMovieContext");
                }

                // Look for any movies.
                if (context.News.Any())
                {
                    return;   // DB has been seeded
                }

                context.News.AddRange(
                    new News
                    {
                        ID =1,
                        Title = " t1aaaa",
                        ImageUrl ="i1aaaa",
                        Content="Connteaaant 1",
                        Author="NPham Gia Khiemaaaa ",
                        CreatedAt ="cc1" 

                    },
                    new News
                    {
                        ID =2,
                        Title = " t1",
                        ImageUrl ="i1aaaaa",
                        Content="c1",
                        Author="a1",
                        CreatedAt ="cc1"
                    },

                    new News
                    {
                        ID =3,
                        Title = " t1aaa",
                        ImageUrl ="i1",
                        Content="c1aaaa",
                        Author="a1",
                        CreatedAt ="cc1"
                    },

                    new News
                    {
                        ID =4,
                        Title = " t1",
                        ImageUrl ="i1",
                        Content="c1aaa",
                        Author="aasaa1",
                        CreatedAt ="cc1"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}

