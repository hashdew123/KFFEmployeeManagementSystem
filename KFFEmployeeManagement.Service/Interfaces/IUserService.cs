using KFFEmployeeManagement.Domain.DTO;
using KFFEmployeeManagement.Domain.Entities;
using KFFEmployeeManagement.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFFEmployeeManagement.Service.Interfaces
{
    public interface IUserService
    {
        Task<string> UserRegisterAsync(UserRegisterModel model);
        Task<AuthenticationModel> GetTokenAsync(TokenRequestModel model);
        Task<string> AddRoleAsync(AddRoleModel model);
        //public void AddUser(User user);

        //public List<UserDTO> GetAllUsers();
    }
}
