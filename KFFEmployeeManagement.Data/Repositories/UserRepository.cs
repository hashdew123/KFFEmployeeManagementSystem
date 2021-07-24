using KFFEmployeeManagement.Data.DBContext;
using KFFEmployeeManagement.Domain.Entities;
using KFFEmployeeManagement.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KFFEmployeeManagement.Data.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(EmployeeContext context) : base(context)
        {
        }
    }
}
