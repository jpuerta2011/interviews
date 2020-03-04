using Interviews.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interviews.Data.Repositories
{
    public interface IInterviewTypesRepository : Base.IBaseRepository<long, InterviewTypes>
    {

    }

    public class InterviewTypesRepository : Base.BaseRepository<long, InterviewTypes>, IInterviewTypesRepository
    {
        public InterviewTypesRepository(InterviewDbContext context) : base(context) { }
    }
}
