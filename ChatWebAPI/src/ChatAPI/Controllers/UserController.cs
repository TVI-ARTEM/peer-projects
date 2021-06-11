using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using ChatAPI.Models;
using ChatAPI.Repositories;

namespace ChatAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        /// <summary>
        /// User database.
        /// </summary>
        private readonly IUserRepository _userRepository;
        /// <summary>
        /// Mail database.
        /// </summary>
        private readonly IMailRepository _mailRepository;


        public UserController(IUserRepository userRepository, IMailRepository mailRepository)
        {
            _userRepository = userRepository;
            _mailRepository = mailRepository;
        }

        /// <summary>
        /// Get all users. 
        /// </summary>
        /// <remarks>
        /// Request:
        /// /api/User/
        /// 
        /// Response:
        /// [{
        /// "salt": "ImiJxCeXgpoE6BFWBT/0mC70awg=",
        /// "pass": "PM4PGNt7AfEHCymLjvY1rHvXfys=",
        /// "login": "login1",
        /// "email": "address1@mail.ru"
        /// }]
        /// </remarks>
        /// <response code="200">Users.</response>
        /// <returns>All users</returns>
        [HttpGet]
        public async Task<IEnumerable<User>> GetUsers()
        {
            return await _userRepository.Get();
        }

        /// <summary>
        /// Get user by user id.
        /// </summary>
        /// <remarks>
        /// Request:
        /// /api/User/address2%40mail.ru
        /// 
        /// Response:
        ///{
        ///  "salt": "PG0dSi4lVJr5WjIr3lgviatVh9E=",
        ///"pass": "la0NDYwjBghkT9bVv8+dJH87h/Y=",
        ///"login": "login2",
        /// "email": "address2@mail.ru"
        ///}
        /// </remarks>
        /// <response code="200">User.</response>
        /// <response code="404">User is not found.</response>
        /// <param name="id">User id - email</param>
        /// <returns>User</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(string id)
        {
            var user = await _userRepository.Get(id);
            if (user == null)
            {
                return NotFound("User is not found");
            }

            return user;
        }

        /// <summary>
        /// Get users with limit and offset
        /// </summary>
        /// <remarks>
        /// Request:
        /// /api/User/GetUsers?limit=1&amp;offset=2
        /// 
        /// Response:
        ///[
        ///{
        ///    "salt": "7joM9JoxfMxpGOzyP+6w1JayXSk=",
        ///    "pass": "fVYsYfzgtC0nwrLmzd8GmibZF6o=",
        ///    "login": "login3",
        ///    "email": "address3@mail.ru"
        ///}
        ///]
        /// </remarks>
        /// <response code="200">Users.</response>
        /// <response code="404">Limit or offset equals or less than 0.</response>
        /// <param name="limit">Limit of users, if limit == null, than limit == users quantity</param>
        /// <param name="offset">Offset of users, if offset == null, that offset == 0</param>
        /// <returns>Users</returns>
        [HttpGet("GetUsers")]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers(int? limit, int? offset)
        {
            if (limit <= 0 || offset < 0)
            {
                return BadRequest("Limit or offset equals or less than 0");
            }

            return new ActionResult<IEnumerable<User>>(await _userRepository.Get(limit, offset));
        }

        /// <summary>
        /// Create new user.
        /// </summary>
        /// <remarks>
        /// Request:
        /// curl -X POST "https://localhost:44390/api/User" -H  "accept: text/plain" -H  "Content-Type: application/json" -d
        /// "{\"login\":\"ART\",\"email\":\"ART@mail.ru\",\"password\":\"QW12\"}"
        /// 
        /// Response:
        ///{
        ///    "salt": "Bn9qTfqtvqwTZmlb69hKR53xx8M=",
        ///    "pass": "TbkqNimqvhiC6jIKwvAXxFqHZW4=",
        ///    "login": "ART",
        ///    "email": "ART@mail.ru"
        ///}
        /// </remarks>
        /// <response code="200">Created user.</response>
        /// <param name="user">New user.</param>
        /// <returns>Created user.</returns>
        [HttpPost]
        public async Task<ActionResult<User>> PostUser([FromBody] User user)
        {
            var newUser = await _userRepository.Create(user);
            return CreatedAtAction(nameof(GetUser), new {id = newUser.Email}, newUser);
        }

        /// <summary>
        /// Generate users.
        /// </summary>
        /// <remarks>
        /// Request:
        /// api/User/Generate?count=1
        /// 
        /// Response:
        /// Users are generated
        /// </remarks>
        /// <response code="200">Users are generated.</response>
        /// <response code="400">Count equals or less than 0.</response>
        /// <param name="count">Quantity of users, if count == null, than generate about 4 to 11 users.</param>
        /// <returns>Message: Users are generated</returns>
        [HttpPost("Generate")]
        public async Task<ActionResult> GenerateUsers(int? count)
        {
            if (count <= 0)
            {
                return BadRequest("Count equals or less than 0");
            }

            await _userRepository.Generate(count);
            return Ok("Users are generated");
        }


        /// <summary>
        /// Delete user and user's mails.
        /// </summary>
        /// <remarks>
        /// Request:
        /// /api/User?userId=address1%40mail.ru
        /// 
        /// Response:
        /// The user is deleted
        /// </remarks>
        /// <response code="200">The user is deleted.</response>
        /// <response code="404">User is not found.</response>
        /// <param name="userId">User id - email</param>
        /// <returns>Message: The user is deleted</returns>
        [HttpDelete]
        public async Task<ActionResult> DeleteUser(string userId)
        {
            var userToDelete = await _userRepository.Get(userId);
            if (userToDelete == null)
            {
                return NotFound("User is not found");
            }

            var mails = await _mailRepository.Get(userId);
            foreach (var mail in mails)
            {
                await _mailRepository.Delete(mail);
            }

            await _userRepository.Delete(userToDelete);
            return Ok("The user is deleted");
        }

        /// <summary>
        /// Update user's login or password.
        /// </summary>
        /// <remarks>
        /// Request:
        /// /api/User?userId=address1%40mail.ru
        /// 
        /// Response:
        /// User's data is updated.
        /// </remarks>
        /// <response code="200">User's data is updated.</response>
        /// <response code="400">Incorrect user email.</response>
        /// <param name="userId">User id - email.</param>
        /// <param name="user">New user's data.</param>
        /// <returns>Message: User's data is updated.</returns>
        [HttpPut]
        public async Task<ActionResult> PutUser(string userId, [FromBody] User user)
        {
            if (userId != user.Email)
            {
                return BadRequest("Incorrect user email");
            }

            await _userRepository.Update(user);
            return Ok("User's data is updated.");
        }
    }
}