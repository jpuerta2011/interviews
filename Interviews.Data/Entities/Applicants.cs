using System;
using System.Collections.Generic;

namespace Interviews.Data.Entities
{
    public partial class Applicants
    {
        public Applicants()
        {
            Interviews = new HashSet<Interviews>();
        }

        public long ApplicantId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Street { get; set; }
        public string Suite { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public double Lat { get; set; }
        public double Lon { get; set; }

        public virtual ICollection<Interviews> Interviews { get; set; }
    }
}
