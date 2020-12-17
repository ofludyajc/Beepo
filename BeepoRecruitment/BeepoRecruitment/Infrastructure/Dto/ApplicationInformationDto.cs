using System;
using BeepoRecruitment.Models;

namespace BeepoRecruitment.Infrastructure.Dto
{
    public class ApplicationInformationDto
    {
        public string ApplicationID { get; set; }

        public int EmployeeID { get; set; }

        public string CandidateID { get; set; }

        public string AppointmentName { get; set; }

        public DateTime AppointmentDate { get; set; }

        public string ApplicationStatus { get; set; }

        public virtual BeepoEmployeeDto BeepoEmployee { get; set; }
    }
}
