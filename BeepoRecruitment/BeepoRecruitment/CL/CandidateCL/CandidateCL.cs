using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.Caching;
using AutoMapper;
using BeepoRecruitment.Models;
using BeepoRecruitment.Infrastructure.Dto;
using BeepoRecruitment.Infrastructure.Helper;
using BeepoRecruitment.Common;

namespace BeepoRecruitment.CL.CandidateCL
{
    public class CandidateCL : ICandidateCL
    {
        private readonly IMapper mapper;
        Utilities utilities = new Utilities();
        ObjectCache cache = MemoryCache.Default;

        public CandidateCL(IMapper mapper)
        {
            this.mapper = mapper;
        }

        public async Task<List<CandidateDto>> GetCandidates()
        {
            var cacheKey = CacheKeys.CandidateCacheKeys.CANDIDATES;
            var candidatesCached = (List<Candidate>)cache.Get(cacheKey);

            if (candidatesCached == null)
            {
                throw new Exception();
            }

            await Task.CompletedTask;

            return mapper.Map<List<CandidateDto>>(candidatesCached);
        }

        public async Task<CandidateDto> GetCandidateByID(string ID)
        {
            var cacheKey = CacheKeys.CandidateCacheKeys.CANDIDATES;
            var candidatesCached = (List<Candidate>)cache.Get(cacheKey);
            var candidate = new Candidate();

            if (candidatesCached == null)
            {
                throw new Exception();
            }

            else
            {
                candidate = candidatesCached.SingleOrDefault(c => c.CandidateID == ID);

                if (candidate == null)
                {
                    throw new Exception();
                }

                await Task.CompletedTask;

                return mapper.Map<CandidateDto>(candidate);
            }
        }

        public async Task<CandidateDto> CreateNewCandidate(CandidateDto candidateDto)
        {
            var cacheKey = CacheKeys.CandidateCacheKeys.CANDIDATES;
            var candidatesCached = (List<Candidate>)cache.Get(cacheKey);
            var candidates = new List<Candidate>();
            var candidate = new Candidate();

            if (candidatesCached == null)
            {
                var entity = await PopulateCandidate(candidateDto);
                candidates.Add(entity);
                cache.Set(cacheKey, candidates, DateTime.Now.AddMinutes(60), null);
                candidate = entity;
            }

            else
            {
                candidate = candidatesCached.SingleOrDefault(c => c.CandidateID == candidateDto.CandidateID);

                if (candidate != null)
                {
                    throw new Exception();
                }

                var entity = await PopulateCandidate(candidateDto);
                candidates.AddRange(candidatesCached);
                candidates.Add(entity);
                cache.Set(cacheKey, candidates, DateTime.Now.AddMinutes(60), null);
                candidate = entity;
            }

            await Task.CompletedTask;

            return mapper.Map<CandidateDto>(candidate);
        }

        public async Task<Candidate> PopulateCandidate(CandidateDto candidateDto)
        {
            var entity = new Candidate()
            {
                CandidateID = utilities.GenerateCandidateID(),
                CandidateName = candidateDto.CandidateName,
                CandidatePosition = candidateDto.CandidatePosition,
                CandidateRole = candidateDto.CandidateRole,
                CandidateSalary = candidateDto.CandidateSalary,
                Remarks = candidateDto.Remarks,
                Contact = new Contact
                {
                    ContactID = utilities.GenerateContactID(),
                    EmailAddress = candidateDto.Contact.EmailAddress,
                    MobileNumber = candidateDto.Contact.MobileNumber,
                    PhysicalAddress = candidateDto.Contact.PhysicalAddress
                },
                ApplicationInformation = new ApplicationInformation
                {
                    ApplicationID = utilities.GenerateApplicationID(),
                    CandidateID = candidateDto.CandidateID,
                    EmployeeID = candidateDto.ApplicationInformation.EmployeeID,
                    AppointmentName = candidateDto.ApplicationInformation.AppointmentName,
                    AppointmentDate = candidateDto.ApplicationInformation.AppointmentDate,
                    ApplicationStatus = candidateDto.ApplicationInformation.ApplicationStatus,
                    BeepoEmployee = new BeepoEmployee
                    {
                        EmployeeID = candidateDto.ApplicationInformation.EmployeeID,
                        EmployeeName = candidateDto.ApplicationInformation.BeepoEmployee.EmployeeName,
                        EmployeePosition = candidateDto.ApplicationInformation.BeepoEmployee.EmployeePosition
                    }
                }
            };

            await Task.CompletedTask;

            return entity;
        }

        public async Task<string> DeleteCandidateByID(string ID)
        {
            var cacheKey = CacheKeys.CandidateCacheKeys.CANDIDATES;
            var candidateCached = (List<Candidate>)cache.Get(cacheKey);
            var candiadteByID = new Candidate();

            if (candidateCached == null)
            {
                throw new Exception();
            }

            else
            {
                candiadteByID = candidateCached.SingleOrDefault(c => c.CandidateID == ID);

                if (candiadteByID == null)
                {
                    throw new Exception();
                }

                candidateCached.Remove(candiadteByID);
                cache.Set(cacheKey, candidateCached, DateTime.Now.AddMinutes(60), null);
            }

            await Task.CompletedTask;

            return ID;
        }

    }
}
