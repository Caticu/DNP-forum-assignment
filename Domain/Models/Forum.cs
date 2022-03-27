namespace Domain.Models;

public class Forum
{
    public ICollection<Post> Posts { get; set; }
    public ICollection<User> Users { get; set; }
}