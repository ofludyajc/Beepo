using System;
using BeepoRecruitment.Models;

namespace BeepoRecruitment.Infrastructure.Dto
{
    public class CandidateDto
    {
        public string CandidateID { get; set; }

        public string CandidateName { get; set; }

        public string CandidateRole { get; set; }

        public string CandidatePosition { get; set; }

        public int CandidateSalary { get; set; }

        public string Remarks { get; set; }

        public virtual ContactDto Contact { get; set; }

        public virtual ApplicationInformationDto ApplicationInformation { get; set; }
    }
}
