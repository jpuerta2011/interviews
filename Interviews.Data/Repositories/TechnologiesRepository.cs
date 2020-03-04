using Interviews.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interviews.Data.Repositories
{
    public interface ITechnologiesRepository : Base.IBaseRepository<long, Technologies>
    {

    }

    public class TechnologiesRepository : Base.BaseRepository<long, Technologies>, ITechnologiesRepository
    {
        public TechnologiesRepository(InterviewDbContext context) : base(context) { }
    }
}
