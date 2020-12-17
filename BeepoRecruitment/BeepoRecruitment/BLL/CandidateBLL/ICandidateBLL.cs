using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeepoRecruitment.Infrastructure.Dto;

namespace BeepoRecruitment.BLL.CandidateBLL
{
    public interface ICandidateBLL
    {
        Task<List<CandidateDto>> GetCandidates();

        Task<CandidateDto> GetCandidateByID(string ID);

        Task<CandidateDto> CreateNewCandidate(CandidateDto candidateDto);

        Task<string> DeleteCandidateByID(string ID);
    }
}
