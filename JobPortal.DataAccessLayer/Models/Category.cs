using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.DataAccess.Models
{
    public class Category:BaseEntity
    {
        
        public string Name { get; set; }
        public  string  icon { get; set; }
    }
}
