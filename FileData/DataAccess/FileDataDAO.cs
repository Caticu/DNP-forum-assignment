using Domain.Contracts;
using Domain.Models;

namespace FileData.DataAccess;

public class FileDataDAO : IPostService, IUserService
{
    private FileContext _fileContext;

    public FileDataDAO(FileContext fileContext)
    {
        _fileContext = fileContext;
    }


    public async Task<ICollection<Post>> GetPostAsync()
    {
        return _fileContext.Forum.Posts;
    }

    public async Task<Post> GetPostByID(string id)
    {
        return _fileContext.Forum.Posts.First(t=>t.Id.Equals(id));
    }

    public async Task<Post> AddPost(Post post)
    {
        _fileContext.Forum.Posts.Add(post);
        _fileContext.SaveChanges();
        return post;
    }

    

    public async Task<ICollection<User>> GetUsersAsync()
    {
        return _fileContext.Forum.Users;
    }

    public async Task<User> GetUserByID(string id)
    {
        return _fileContext.Forum.Users.First(t=>t.Id.Equals(id));
    }

    public async Task<User> GetUser(string username)
    {
        return _fileContext.Forum.Users.First(t=>t.UserName.Equals(username));
    }

    public async Task<User> AddUser(User user)
    {
        if (_fileContext.Forum.Users.Any(t=>t.UserName.Equals(user.UserName)))
        {
            throw new Exception("Username already in use!");
        }
        else
        {
            
            _fileContext.Forum.Users.Add(user);
            _fileContext.SaveChanges();
            return user;
        }
        
    }

    public async Task DeleteUser(string id)
    {
        User toDelete = _fileContext.Forum.Users.First(t => t.Id.Equals(id));
        _fileContext.Forum.Users.Remove(toDelete);
        _fileContext.SaveChanges();
    }

    public async Task UpdateUser(User user)
    {
        User toUpdate = _fileContext.Forum.Users.First(t => t.Id.Equals(user.Id));
        toUpdate.UserName = user.UserName;
        toUpdate.Password = user.Password;
        toUpdate.Role = user.Role;
        toUpdate.BirthDate = user.BirthDate;
        toUpdate.City = user.City;
        _fileContext.SaveChanges();
    }
} 