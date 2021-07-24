using System;
using System.Collections.Generic;
using System.Text;

namespace KFFEmployeeManagement.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository Users { get; }

        int Complete();

    }
}
