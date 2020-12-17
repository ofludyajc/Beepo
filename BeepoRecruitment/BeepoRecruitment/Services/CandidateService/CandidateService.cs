using BeepoRecruitment.BLL.CandidateBLL;
using BeepoRecruitment.Infrastructure.Dto;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace BeepoRecruitment.Services.CandidateService
{
    public class CandidateService : ICandidateService
    {
        private readonly ICandidateBLL candidateBLL;

        public CandidateService(ICandidateBLL candidateBLL)
        {
            this.candidateBLL = candidateBLL;
        }

        public async Task<List<CandidateDto>> GetCandidates()
        {
            var result = await candidateBLL.GetCandidates();

            return result;
        }

        public async Task<CandidateDto> GetCandidateByID(string ID)
        {
            var candidateByID = await candidateBLL.GetCandidateByID(ID);

            return candidateByID;
        }

        public async Task<CandidateDto> CreateNewCandidate(CandidateDto candidateDto)
        {
            var candidate = await candidateBLL.CreateNewCandidate(candidateDto);

            return candidate;
        }

        public async Task<string> DeleteCandidateByID(string ID)
        {
            var result = await candidateBLL.DeleteCandidateByID(ID);

            return result;
        }
    }
}
