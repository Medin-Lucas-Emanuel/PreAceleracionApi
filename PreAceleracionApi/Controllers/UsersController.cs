using Microsoft.AspNetCore.Mvc;
using PreAceleracionApi.Models;
using PreAceleracionApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PreAceleracionApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : Controller
    {
        private readonly IUserRepository _userRepository;

        public UsersController (IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAllUsers()
        {
            var User = await _userRepository.GetAllUsersAsync();

            return Ok(User);
        }

        //[HttpPost("")]
        //public async Task<IActionResult> AddNewUser([FromBody] UsersModels usersModels)
        //{
        //    var id = await _userRepository.AddUserAsync(usersModels)

        //        return CreatedAtAction(nameof(GetUserById), new { id = id, controller = "Users" }, id);
        //}
    }
}
