﻿using Application.DAOInterfaces;
using Domain.Contracts;
using Domain.Models;

namespace Application.ServicesImpl;

public class UserServiceImpl : IPostService
{
    public Task<ICollection<Post>> GetPostAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Post> GetPostByID(string id)
    {
        throw new NotImplementedException();
    }

    public Task<Post> AddPost(Post post)
    {
        throw new NotImplementedException();
    }
}