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

namespace BeepoRecruitment.CL.ApplicationCL
{
    public class ApplicationCL : IApplicationCL
    {
        private readonly IMapper mapper;
        Utilities utilities = new Utilities();
        ObjectCache cache = MemoryCache.Default;

        public ApplicationCL(IMapper mapper)
        {
            this.mapper = mapper;
        }

        public async Task<List<ApplicationInformationDto>> GetApplicationInformation()
        {
            var cacheKey = CacheKeys.ApplicationCacheKeys.APPLICATIONS;
            var applicationCached = (List<ApplicationInformation>)cache.Get(cacheKey);

            if (applicationCached == null)
            {
                throw new Exception();
            }

            await Task.CompletedTask;

            return mapper.Map<List<ApplicationInformationDto>>(applicationCached);
        }

        public async Task<ApplicationInformationDto> GetApplicationInformationByID(string ID)
        {
            var cacheKey = CacheKeys.ApplicationCacheKeys.APPLICATIONS;
            var applicationsCached = (List<ApplicationInformation>)cache.Get(cacheKey);
            var application = new ApplicationInformation();

            if (applicationsCached == null)
            {
                throw new Exception();
            }

            else
            {
                application = applicationsCached.SingleOrDefault(c => c.CandidateID == ID);

                if (application == null)
                {
                    throw new Exception();
                }

                await Task.CompletedTask;

                return mapper.Map<ApplicationInformationDto>(application);
            }
        }

    }
}
