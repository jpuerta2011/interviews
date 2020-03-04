using System;
using System.Collections.Generic;
using System.Text;

namespace Interviews.Services.Models
{
    public class Applicants
    {
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
    }
}
