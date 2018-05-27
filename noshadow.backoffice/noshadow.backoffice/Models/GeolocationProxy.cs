using System;

namespace noshadow.backoffice.Models
{
    public class GeolocationProxy
    {
        public DateTime LogDate { get; set; }

        public string Latitude { get; set; }
        public string Longitude { get; set; }
        
        public string Speed { get; set; }
        public string Height { get; set; }
        
        
        public string DeviceId { get; set; }
    }
}