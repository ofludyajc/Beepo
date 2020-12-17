using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeepoRecruitment.Services.CandidateService;
using BeepoRecruitment.Infrastructure.Dto;
using Microsoft.AspNetCore.Mvc;

namespace BeepoRecruitment.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CandidateController : ControllerBase
    {
        private readonly ICandidateService candidateService;

        public CandidateController(ICandidateService candidateService)
        {
            this.candidateService = candidateService;
        }

        [HttpGet("GetCandidates")]
        public async Task<ActionResult<IEnumerable<CandidateDto>>> GetCandidates()
        {
            var result = await candidateService.GetCandidates();

            return result;
        }

        [HttpGet("GetCandidate/{ID}")]
        public async Task<ActionResult<CandidateDto>> GetCandidateByID(string ID)
        {
            var result = await candidateService.GetCandidateByID(ID);

            return result;
        }

        [HttpPost("CreateCandidate")]
        public async Task<CandidateDto> CreateCandidate([FromBody] CandidateDto candidateDto)
        {
            var result = await candidateService.CreateNewCandidate(candidateDto);

            return result;
        }

        [HttpDelete("DeleteCandidateBy/{ID}")]
        public async Task<string> DeleteCandidateByID(string candidateID)
        {
            var result = await candidateService.DeleteCandidateByID(candidateID);

            return result;
        }
    }
}
