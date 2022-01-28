using PreAceleracionApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PreAceleracionApi.Repository
{
    public interface IUserRepository
    {
        Task<int> AddUserAsync(UsersModels usersModel);
        Task<List<UsersModels>> GetAllUsersAsync();
    }
}
