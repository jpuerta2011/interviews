using System;
using System.Threading.Tasks;
using Interviews.Common.Dependencies.UnitOfWork;
using Microsoft.EntityFrameworkCore;

namespace Interviews.Configuration
{
    public class UnitOfWork : IUnitOfWork
    {
        /// <summary>
        /// The session
        /// </summary>
        private readonly DbContext _context;

        public UnitOfWork(DbContext context)
        {
            _context = context ?? throw new ArgumentNullException("context");
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
