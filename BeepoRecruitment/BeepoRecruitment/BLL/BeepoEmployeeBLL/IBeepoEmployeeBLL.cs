using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BeepoRecruitment.Infrastructure.Dto;

namespace BeepoRecruitment.BLL.BeepoEmployeeBLL
{
    public interface IBeepoEmployeeBLL
    {
        Task<List<BeepoEmployeeDto>> GetBeepoEmployees();

        Task<BeepoEmployeeDto> GetEmployeeByID(int ID);
    }
}
