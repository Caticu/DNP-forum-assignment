namespace Application.DAOInterfaces;
using Domain.Models;

public interface IPostDAO
{
    public Task<ICollection<Post>> GetPostAsync();
    public Task<Post> GetPostByID(string id);
    public Task<Post> AddPost(Post post);
    public Task DeletePost(string id);
    public Task UpdatePost(Post post);
    public Task<ICollection<User>> GetUserAsync();
    public Task<User> GetUserByID(string id);
    public Task<User> GetUser(string username);
    public Task<User> AddUser(User user);
    public Task DeleteUser(string id);
    public Task UpdateUser(User user);
}