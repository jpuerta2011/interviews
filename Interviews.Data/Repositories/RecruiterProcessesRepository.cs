using Interviews.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interviews.Data.Repositories
{
    public interface IRecruiterProcessesRepository : Base.IBaseRepository<long, RecruiterProcesses>
    {

    }

    public class RecruiterProcessesRepository : Base.BaseRepository<long, RecruiterProcesses>, IRecruiterProcessesRepository
    {
        public RecruiterProcessesRepository(InterviewDbContext context) : base(context) { }
    }
}
