using System;

namespace BeepoRecruitment.Models
{
    public class BeepoEmployee
    {
        public int EmployeeID { get; set; }

        public string EmployeeName { get; set; }

        public string EmployeeRole { get; set; }

        public string EmployeePosition { get; set; }

        public int ContactID { get; set; }

        public virtual Contact Contact { get; set;}
    }
}
