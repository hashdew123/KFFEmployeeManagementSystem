using KFFEmployeeManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KFFEmployeeManagement.Domain.DTO
{
    public class UserDTO
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public RoleDTO Role { get; set; }
    }
}
