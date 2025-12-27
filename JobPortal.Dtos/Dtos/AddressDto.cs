using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.Dtos.Dtos
{
    public class AddressDto
    {
        public Guid? UserId { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public Guid? StateId { get; set; }
        public Guid? CountryId { get; set; }
        
    }
}
