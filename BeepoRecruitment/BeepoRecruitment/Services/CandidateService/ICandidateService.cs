using BeepoRecruitment.Infrastructure.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BeepoRecruitment.Services.CandidateService
{
    public interface ICandidateService
    {
        Task<List<CandidateDto>> GetCandidates();

        Task<CandidateDto> GetCandidateByID(string ID);

        Task<CandidateDto> CreateNewCandidate(CandidateDto candidateDto);

        Task<string> DeleteCandidateByID(string ID);
    }
}
