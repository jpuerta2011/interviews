using System;
using System.Collections.Generic;

namespace Interviews.Data.Entities
{
    public partial class RecruiterProcessTechnologies
    {
        public long RecruiterProcessTechnologyId { get; set; }
        public long TechnologyId { get; set; }
        public long RecruiterProcessId { get; set; }
        public bool? State { get; set; }

        public virtual RecruiterProcesses RecruiterProcess { get; set; }
        public virtual Technologies Technology { get; set; }
    }
}
