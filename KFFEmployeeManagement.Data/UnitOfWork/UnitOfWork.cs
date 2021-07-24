using KFFEmployeeManagement.Data.DBContext;
using KFFEmployeeManagement.Data.Repositories;
using KFFEmployeeManagement.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace KFFEmployeeManagement.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EmployeeContext _context;

        public UnitOfWork(EmployeeContext context)
        {
            _context = context;
            Users = new UserRepository(_context);
        }

        public IUserRepository Users { get; private set; }
        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
