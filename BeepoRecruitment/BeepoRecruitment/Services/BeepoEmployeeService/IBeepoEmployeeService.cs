using BeepoRecruitment.Infrastructure.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BeepoRecruitment.Services.BeepoEmployeeService
{
    public interface IBeepoEmployeeService
    {
        Task<List<BeepoEmployeeDto>> GetBeepoEmployees();

        Task<BeepoEmployeeDto> GetEmployeeByID(int ID);
    }
}
