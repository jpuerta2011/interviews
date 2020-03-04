using System;
using System.Threading.Tasks;
using Interviews.Common.Dependencies.UnitOfWork;
using Interviews.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Interviews.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        /// <summary>
        /// The session
        /// </summary>
        private readonly InterviewDbContext _context;

        public UnitOfWork(InterviewDbContext context)
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
