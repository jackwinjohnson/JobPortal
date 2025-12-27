using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.DataAccess.Models
{
    public class Skill:BaseEntity
    {
        public  string Name { get; set; }

        public  Guid   CategoryId { get; set; }


    }
}
