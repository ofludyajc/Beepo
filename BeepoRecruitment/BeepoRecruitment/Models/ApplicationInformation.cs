using System;

namespace BeepoRecruitment.Models
{
    public class ApplicationInformation
    {
        public string ApplicationID { get; set; }

        public int EmployeeID { get; set; }

        public string CandidateID { get; set; }

        public string AppointmentName { get; set; }

        public DateTime AppointmentDate { get; set; }

        public string ApplicationStatus { get; set; }

        public virtual BeepoEmployee BeepoEmployee { get; set; }
    }
}
