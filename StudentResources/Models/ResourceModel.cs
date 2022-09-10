using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentResources.Models
{
    public class ResourceModel
    {
        public int ResourceId { get; set; }
        public string ResourceName { get; set; }
        public string ResourceType { get; set; }
        public bool ResourceAvailability { get; set; }
        public int ResourceQuantity { get; set; }
    }
}
