using Interviews.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interviews.Data.Repositories
{
    public interface IApplicantsRepository : Base.IBaseRepository<long, Applicants>
    {

    }

    public class ApplicantsRepository : Base.BaseRepository<long, Applicants>, IApplicantsRepository
    {
        public ApplicantsRepository(InterviewDbContext context) : base(context) { }
    }
}
