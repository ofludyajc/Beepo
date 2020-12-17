using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeepoRecruitment.Infrastructure.Dto;

namespace BeepoRecruitment.CL.CandidateCL
{
    public interface ICandidateCL
    {
        Task<List<CandidateDto>> GetCandidates();

        Task<CandidateDto> GetCandidateByID(string ID);

        Task<CandidateDto> CreateNewCandidate(CandidateDto candidate);

        Task<string> DeleteCandidateByID(string ID);
    }
}
