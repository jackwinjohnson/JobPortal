using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.DataAccess.Models
{
    public class Country:BaseEntity
    {
        public string  Name { get; set; }
        public ICollection<State> States { get; set; }
    }
}
