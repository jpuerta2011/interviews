using System;
using System.Collections.Generic;

namespace Interviews.Data.Entities
{
    public partial class InterviewTypes
    {
        public InterviewTypes()
        {
            Interviews = new HashSet<Interviews>();
        }

        public long InterviewTypeId { get; set; }
        public string Name { get; set; }
        public bool? State { get; set; }

        public virtual ICollection<Interviews> Interviews { get; set; }
    }
}
