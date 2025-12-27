using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.DataAccess.Models
{
    public class WorkExprience:BaseEntity
    {
        public Guid EmployeeId{ get; set; }
        public  string  CompanyName {  get; set; }
        public string JobTitle { get; set; }


        public  DateOnly StartDate {  get; set; }
        public DateOnly EndDate { get; set; }
        public  string  Responsblity {  get; set; }

        public string Description { get; set; }
    }
}
