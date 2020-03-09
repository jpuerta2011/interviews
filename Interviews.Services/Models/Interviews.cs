using System;
using System.Collections.Generic;
using System.Text;

namespace Interviews.Services.Models
{
    public class Interviews
    {
        public long InterviewId { get; set; }
        public long RecruiterProcessId { get; set; }
        public long ApplicantId { get; set; }
        public string ApplicantName { get; set; }
        public DateTime Date { get; set; }
        public string Time { get; set; }
        public long InterviewTypeId { get; set; }
        public string InterviewTypeName { get; set; }
        public bool? State { get; set; }
        public Applicants Applicant { get; set; }
    }
}
