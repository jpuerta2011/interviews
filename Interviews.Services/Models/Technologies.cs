using System;
using System.Collections.Generic;
using System.Text;

namespace Interviews.Services.Models
{
    public class Technologies
    {
        public long TechnologyId { get; set; }
        public string Name { get; set; }
        public long? ParentTechnologyId { get; set; }
        public bool? State { get; set; }
        public short Code { get; set; }
    }
}
