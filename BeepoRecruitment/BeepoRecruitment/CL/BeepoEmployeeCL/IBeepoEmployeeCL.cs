using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeepoRecruitment.Infrastructure.Dto;

namespace BeepoRecruitment.CL.BeepoEmployeeCL
{
    public interface IBeepoEmployeeCL
    {
        Task<List<BeepoEmployeeDto>> GetBeepoEmployees();

        Task<BeepoEmployeeDto> GetEmployeeByID(int ID);
    }
}
