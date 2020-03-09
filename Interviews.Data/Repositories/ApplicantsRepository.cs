using Interviews.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interviews.Data.Repositories
{
    public interface IApplicantsRepository : Base.IBaseRepository<int, Applicants>
    {

    }

    public class ApplicantsRepository : Base.BaseRepository<int, Applicants>, IApplicantsRepository
    {
        public ApplicantsRepository(InterviewDbContext context) : base(context) { }
    }
}
