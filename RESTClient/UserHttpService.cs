using Domain.Contracts;
using Domain.Models;

namespace RESTClient;

public class UserHttpService : IUserService
{
    public Task<ICollection<User>> GetUsersAsync()
    {
        throw new NotImplementedException();
    }

    public Task<User> GetUserByID(string id)
    {
        throw new NotImplementedException();
    }

    public Task<User> GetUser(string username)
    {
        throw new NotImplementedException();
    }

    public Task<User> AddUser(User user)
    {
        throw new NotImplementedException();
    }

    public Task DeleteUser(string id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateUser(User user)
    {
        throw new NotImplementedException();
    }
}