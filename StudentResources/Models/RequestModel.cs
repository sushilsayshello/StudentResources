using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentResources.Models
{
    public class RequestModel
    {
        public int RequestId { get; set; }
        public int StudentId { get; set; }
        public int ResourceId { get; set; }
        public bool Approval { get; set; }

    }
}
