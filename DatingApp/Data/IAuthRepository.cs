﻿using DatingApp.Models;
using System.Threading.Tasks;

namespace DatingApp.Data
{
    public interface IAuthRepository
    {
        Task<User> Register(User user,string password);
        Task<User> Login(string username, string password);
        Task<bool> UserExists(string username);
    }
}