using System;
using System.Collections.Generic;
using System.Text;

namespace Interviews.Services.Models
{
    public class RecruiterProcessTechnologies
    {
        public long RecruiterProcessTechnologyId { get; set; }
        public long TechnologyId { get; set; }
        public long RecruiterProcessId { get; set; }
        public bool? State { get; set; }
        public string TechnologyName { get; set; }
    }
}
