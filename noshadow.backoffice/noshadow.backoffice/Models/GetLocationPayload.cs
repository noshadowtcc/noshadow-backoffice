using System;

namespace noshadow.backoffice.Models
{
    public class GetLocationPayload
    {
        public DateTime? Start { get; set; }
        
        public DateTime? End { get; set; }
        
        public Guid DeviceId { get; set; }
    }
}