using System;
using System.Collections.Generic;
using System.Text;

namespace Interviews.Services.Models
{
    public class InterviewTypes
    {
        public long InterviewTypeId { get; set; }
        public string Name { get; set; }
        public bool? State { get; set; }
    }
}
