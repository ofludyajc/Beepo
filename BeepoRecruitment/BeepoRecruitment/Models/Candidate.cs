using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeepoRecruitment.Models
{
    public class Candidate
    {
        public string CandidateID { get; set; }

        public string CandidateName { get; set; }

        public string CandidateRole { get; set; }

        public string CandidatePosition { get; set; }

        public int CandidateSalary { get; set; }

        public string Remarks { get; set; }

        public virtual Contact Contact { get; set; }

        public virtual ApplicationInformation ApplicationInformation { get; set; }
    }
}
