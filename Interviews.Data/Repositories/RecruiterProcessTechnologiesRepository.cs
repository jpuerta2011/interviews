using Interviews.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interviews.Data.Repositories
{
    public interface IRecruiterProcessTechnologiesRepository : Base.IBaseRepository<long, RecruiterProcessTechnologies>
    {

    }

    public class RecruiterProcessTechnologiesRepository : Base.BaseRepository<long, RecruiterProcessTechnologies>,
        IRecruiterProcessTechnologiesRepository
    {
        public RecruiterProcessTechnologiesRepository(InterviewDbContext context) : base(context) { }
    }
}
