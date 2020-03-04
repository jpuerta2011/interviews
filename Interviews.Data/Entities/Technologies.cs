using System;
using System.Collections.Generic;

namespace Interviews.Data.Entities
{
    public partial class Technologies
    {
        public Technologies()
        {
            RecruiterProcessTechnologies = new HashSet<RecruiterProcessTechnologies>();
        }

        public long TechnologyId { get; set; }
        public string Name { get; set; }
        public long? ParentTechnologyId { get; set; }
        public bool? State { get; set; }

        public virtual ICollection<RecruiterProcessTechnologies> RecruiterProcessTechnologies { get; set; }
    }
}
