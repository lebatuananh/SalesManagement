using System;

namespace SalesManagement.ConsoleApp.Infrastructure.Infrastructure.Interfaces
{
    public interface IUnitOfWork:IDisposable
    {
        void Commit();
    }
}