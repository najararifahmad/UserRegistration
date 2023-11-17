using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserRegistration.Shared.Models;

namespace UserRegistration.Shared.Services
{
    public interface IUserRegistrationService
    {
        Task<ResponseDto> GetUsersAsync(int pageNo, int pageSize);
        Task<ResponseDto> AddUserAsync(User user);
        Task<ResponseDto> UpdateUserAsync(User user);
        Task<ResponseDto> DeleteUserAsync(int userId);
    }
}
