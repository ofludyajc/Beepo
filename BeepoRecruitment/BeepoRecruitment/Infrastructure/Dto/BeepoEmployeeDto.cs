using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeepoRecruitment.Models;

namespace BeepoRecruitment.Infrastructure.Dto
{
    public class BeepoEmployeeDto
    {
        public int EmployeeID { get; set; }

        public string EmployeeName { get; set; }

        public string EmployeeRole { get; set; }

        public string EmployeePosition { get; set; }

        public int ContactID { get; set; }

        public virtual ContactDto Contact { get; set; }
    }
}
