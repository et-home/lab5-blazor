using Microsoft.EntityFrameworkCore;
namespace Blazor_blog.Models;

public class BlogContext : DbContext
{
    public BlogContext(DbContextOptions<BlogContext> options)
        : base(options)
    {
    }

    public DbSet<BlogEntry> Blog { get; set; }
}