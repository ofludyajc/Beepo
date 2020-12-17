using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.Caching;
using AutoMapper;
using BeepoRecruitment.Models;
using BeepoRecruitment.Infrastructure.Dto;
using BeepoRecruitment.Common;

namespace BeepoRecruitment.CL.BeepoEmployeeCL
{
    public class BeepoEmployeeCL : IBeepoEmployeeCL
    {
        private readonly IMapper mapper;
        ObjectCache cache = MemoryCache.Default;
        private readonly Constants constants = new Constants();

        public BeepoEmployeeCL(IMapper mapper)
        {
            this.mapper = mapper;
        }

        public async Task<List<BeepoEmployeeDto>> GetBeepoEmployees()
        {
            var beepoEmployees = new List<BeepoEmployee>();
            var cacheKey = CacheKeys.BeepoEmployees.BEEPOEMPLOYEES;
            var BECached = (List<BeepoEmployee>)cache.Get(cacheKey);

            if (BECached == null)
            {
                var bec = await Task.Run(() => constants.beepoEmployees);
                cache.Set(cacheKey, bec, DateTime.Now.AddMinutes(60), null);
                beepoEmployees = bec;
            }

            else
            {
                beepoEmployees = BECached;
            }

            return mapper.Map<List<BeepoEmployeeDto>>(beepoEmployees);
        }

        public async Task<BeepoEmployeeDto> GetEmployeeByID(int ID)
        {
            var cacheKey = CacheKeys.BeepoEmployees.BEEPOEMPLOYEES;
            var BECached = (List<BeepoEmployee>)cache.Get(cacheKey);
            var beByID = new BeepoEmployee();

            if (BECached == null)
            {
                var bec = await Task.Run(() => constants.beepoEmployees);
                beByID = bec.SingleOrDefault(be => be.EmployeeID == ID);

                if (beByID == null)
                {
                    throw new Exception();
                }

                cache.Set(cacheKey, bec, DateTime.Now.AddMinutes(60), null);
            }

            else
            {
                beByID = BECached.SingleOrDefault(be => be.EmployeeID == ID);

                if (beByID == null)
                {
                    throw new Exception();
                }
            }

            return mapper.Map<BeepoEmployeeDto>(beByID);
        }
    }
}
