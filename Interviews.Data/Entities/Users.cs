using System;
using System.Collections.Generic;

namespace Interviews.Data.Entities
{
    public partial class Users
    {
        public Users()
        {
            RecruiterProcesses = new HashSet<RecruiterProcesses>();
        }

        public long UserId { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public virtual ICollection<RecruiterProcesses> RecruiterProcesses { get; set; }
    }
}
