using BeepoRecruitment.BLL.BeepoEmployeeBLL;
using BeepoRecruitment.Infrastructure.Dto;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace BeepoRecruitment.Services.BeepoEmployeeService
{
    public class BeepoEmployeeService : IBeepoEmployeeService
    {
        private readonly IBeepoEmployeeBLL beepoEmployeeBLL;

        public BeepoEmployeeService(IBeepoEmployeeBLL beepoEmployeeBLL)
        {
            this.beepoEmployeeBLL = beepoEmployeeBLL;
        }

        public async Task<List<BeepoEmployeeDto>> GetBeepoEmployees()
        {
            var result = await beepoEmployeeBLL.GetBeepoEmployees();

            return result;
        }

        public async  Task<BeepoEmployeeDto> GetEmployeeByID(int ID)
        {
            var employeeByID = await beepoEmployeeBLL.GetEmployeeByID(ID);

            return employeeByID;
        }
    }
}
