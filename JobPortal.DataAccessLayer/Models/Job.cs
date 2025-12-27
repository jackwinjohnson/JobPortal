using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.DataAccess.Models
{
    public class Job:BaseEntity
    {
        public  string  Title { get; set; }
        public string Description { get; set; }
       

        public decimal  Salary { get; set; }

        public Guid EmpolyerID{ get; set; }

        [ForeignKey("EmpolyerID")]
        public  Empolyer   Empolyer { get; set; }

        public  DateTime    PublishDate { get; set; }

        public  DateTime    ExpieryDate  { get; set; }

        public Guid JobTypeId { get; set; }
        public  JobType JobType { get; set; }
        
        public  Guid    ExperinceLevelId { get; set; }
        public  ExperinceLevel  ExperinceLevel { get; set; }

        public  Guid    CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
