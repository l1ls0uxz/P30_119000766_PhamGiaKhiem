using Microsoft.EntityFrameworkCore;

namespace RazorPagesMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesMovieContext>>()))
            {
                if (context == null || context.Category == null)
                {
                    throw new ArgumentNullException("Null RazorPagesMovieContext");
                }

                // Look for any movies.
                if (context.Category.Any())
                {
                    return;   // DB has been seeded
                }

                context.Category.AddRange(
                    new Category
                    {
                        ID = 1 ,
                        Name = "Phamn 1"
                    },

                    new Category
                    {
                        ID = 2 ,
                        Name = "Pham Minh 1"
                    },

                    new Category
                    {
                        ID = 3 ,
                        Name = "Pham Minh 1"
                    },

                    new Category
                    {
                        ID = 4 ,
                        Name = "Pham Minh 1"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}