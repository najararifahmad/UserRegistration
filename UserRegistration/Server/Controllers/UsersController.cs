using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserRegistration.Shared.Models;
using UserRegistration.Shared.Services;

namespace UserRegistration.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRegistrationService _userRegistrationService;
        public UsersController(IUserRegistrationService userRegistrationService)
        {
            _userRegistrationService = userRegistrationService;
        }
        [HttpGet]
        public async Task<IActionResult> GetUsersAsync(int pageNo, int pageSize)
        {
            try
            {
                return Ok(await _userRegistrationService.GetUsersAsync(pageNo, pageSize));
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public async Task<IActionResult> AddUserAsync(User user)
        {
            try
            {
                return Ok(await _userRegistrationService.AddUserAsync(user));
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        public async Task<IActionResult> UpdateUserAsync(User user)
        {
            try
            {
                return Ok(await _userRegistrationService.UpdateUserAsync(user));
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteUserAsync(int id)
        {
            try
            {
                return Ok(await _userRegistrationService.DeleteUserAsync(id));
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
