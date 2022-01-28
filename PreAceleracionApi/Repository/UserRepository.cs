using Microsoft.EntityFrameworkCore;
using PreAceleracionApi.Data;
using PreAceleracionApi.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PreAceleracionApi.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly DataBaseContext _context;

        public UserRepository (DataBaseContext context)
        {
            _context = context;
        }

        public async Task<int> AddUserAsync(UsersModels usersModel)
        {
            var user = new Users()
            {
                name = usersModel.name,
                password = usersModel.password,
                email = usersModel.email
            };

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return user.id;
        }

        public async Task<List<UsersModels>> GetAllUsersAsync()
        {
            var records = await _context.Users.Select(x => new UsersModels()
            {

                id = x.id,
                name = x.name,
                email = x.email,
                password = x.password

            }).ToListAsync();

            return records;     
        }
    }
}
