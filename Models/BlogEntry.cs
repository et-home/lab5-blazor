
namespace Blazor_blog.Models;
public class BlogEntry : IComparable<BlogEntry>
{
    public uint BlogEntryId { get; set; }
    public string Title { get; set; } = "Blog Entry Title";
    public string Content { get; set; } = "";
    public DateTime TimePosted { get; set; } = DateTime.Now;

    public int CompareTo(BlogEntry? other)
    {
        if (other != null)
        {
            return -1 * TimePosted.CompareTo(other.TimePosted);
        }
        return 1;
    }
}