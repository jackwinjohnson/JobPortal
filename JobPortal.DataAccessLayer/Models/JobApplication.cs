using JobPortal.DataAccess.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.DataAccess.Models
{
    public class JobApplication:BaseEntity
    {
        public  Guid    Jobid { get; set; }
        public  Guid    Employeeid { get; set; }

        public  string  Firstname   { get; set; }

        public  string  Lastname { get; set; }

        public string Qulification { get; set; }

        public  string  Resume { get; set; }

        public string Email { get; set; }

        public  string  PhoneNumber { get; set; }

        public DateTime AppliedOn { get; set; } = DateTime.Now;
        
        public  AppStatus   status { get; set; }

    }
}
