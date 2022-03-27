using Domain.Models;

namespace Domain.Contracts;

public interface IPostService
{
    public Task<ICollection<Post>> GetPostAsync();
    public Task<Post> GetPostByID(string id);
    public Task<Post> AddPost(Post post);
    
}