using Interviews.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interviews.Data.Repositories
{
    public interface IInterviewsRepository : Base.IBaseRepository<long, Entities.Interviews>
    {

    }

    public class InterviewsRepository : Base.BaseRepository<long, Entities.Interviews>, IInterviewsRepository
    {
        public InterviewsRepository(InterviewDbContext context) : base(context) { }
    }
}
