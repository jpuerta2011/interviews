using System;
using System.Collections.Generic;

namespace Interviews.Data.Entities
{
    public partial class RecruiterProcesses
    {
        public RecruiterProcesses()
        {
            Interviews = new HashSet<Interviews>();
            RecruiterProcessTechnologies = new HashSet<RecruiterProcessTechnologies>();
        }

        public long RecruiterProcessId { get; set; }
        public long UserId { get; set; }
        public string Description { get; set; }
        public bool? State { get; set; }

        public virtual Users User { get; set; }
        public virtual ICollection<Interviews> Interviews { get; set; }
        public virtual ICollection<RecruiterProcessTechnologies> RecruiterProcessTechnologies { get; set; }
    }
}
