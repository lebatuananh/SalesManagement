﻿using SalesManagement.ConsoleApp.Infrastructure.Infrastructure.Interfaces;

namespace SalesManagement.ConsoleApp.Domain.Data.EF
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _appDbContext;

        public EFUnitOfWork(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void Dispose()
        {
            _appDbContext.Dispose();
        }

        public void Commit()
        {
            _appDbContext.SaveChanges();
        }
    }
}