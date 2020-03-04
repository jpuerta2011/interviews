using Interviews.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interviews.Data.Repositories
{
    public interface IUsersRepository : Base.IBaseRepository<long, Users>
    {

    }

    public class UsersRepository : Base.BaseRepository<long, Users>, IUsersRepository
    {
        public UsersRepository(InterviewDbContext context) : base(context) { }
    }
}
