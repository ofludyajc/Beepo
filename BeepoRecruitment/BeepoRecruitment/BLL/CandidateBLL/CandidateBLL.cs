using BeepoRecruitment.Infrastructure.Dto;
using BeepoRecruitment.CL.CandidateCL;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BeepoRecruitment.BLL.CandidateBLL
{
    public class CandidateBLL : ICandidateBLL
    {
        private readonly ICandidateCL candidateCL;

        public CandidateBLL(ICandidateCL candidateCL)
        {
            this.candidateCL = candidateCL;
        }

        public async Task<List<CandidateDto>> GetCandidates()
        {
            var candidates = await candidateCL.GetCandidates();

            return candidates;
        }

        public async Task<CandidateDto> GetCandidateByID(string ID)
        {
            var candidateByID = await candidateCL.GetCandidateByID(ID);

            return candidateByID;
        }

        public async Task<CandidateDto> CreateNewCandidate(CandidateDto candidateDto)
        {
            var candidate = await candidateCL.CreateNewCandidate(candidateDto);

            return candidate;
        }

        public async Task<string> DeleteCandidateByID(string ID)
        {
            var candidateByID = await candidateCL.DeleteCandidateByID(ID);

            return candidateByID;
        }
    }
}
