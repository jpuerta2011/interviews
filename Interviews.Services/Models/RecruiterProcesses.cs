using System;
using System.Collections.Generic;
using System.Text;

namespace Interviews.Services.Models
{
    public class RecruiterProcesses
    {
        public long RecruiterProcessId { get; set; }
        public long UserId { get; set; }
        public string Description { get; set; }
        public bool? State { get; set; }
        public IList<RecruiterProcessTechnologies> Technologies { get; set; }
        public IList<Interviews> Interviews { get; set; }
    }
}
