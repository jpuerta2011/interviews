using System;
using System.Collections.Generic;

namespace Interviews.Data.Entities
{
    public partial class Interviews
    {
        public long InterviewId { get; set; }
        public long RecruiterProcessId { get; set; }
        public int ApplicantId { get; set; }
        public DateTime Date { get; set; }
        public long InterviewTypeId { get; set; }
        public bool? State { get; set; }

        public virtual Applicants Applicant { get; set; }
        public virtual InterviewTypes InterviewType { get; set; }
        public virtual RecruiterProcesses RecruiterProcess { get; set; }
    }
}
