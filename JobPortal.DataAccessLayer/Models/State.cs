using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.DataAccess.Models
{
    public class State:BaseEntity
    {
        public string Name { get; set; }
        public Guid CountryID { get; set; }
        public  virtual Country Country { get; set; }

    }
}
