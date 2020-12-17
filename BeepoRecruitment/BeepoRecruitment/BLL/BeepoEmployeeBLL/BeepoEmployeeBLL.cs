using BeepoRecruitment.Infrastructure.Dto;
using BeepoRecruitment.CL.BeepoEmployeeCL;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BeepoRecruitment.BLL.BeepoEmployeeBLL
{
    public class BeepoEmployeeBLL : IBeepoEmployeeBLL
    {
        private readonly IBeepoEmployeeCL beepoEmployeeCL;

        public BeepoEmployeeBLL(IBeepoEmployeeCL beepoEmployeeCL)
        {
            this.beepoEmployeeCL = beepoEmployeeCL;
        }

        public async Task<List<BeepoEmployeeDto>> GetBeepoEmployees()
        {
            var beepoEmployees = await beepoEmployeeCL.GetBeepoEmployees();

            return beepoEmployees;
        }

        public async Task<BeepoEmployeeDto> GetEmployeeByID(int ID)
        {
            var beepoEmployeeByID = await beepoEmployeeCL.GetEmployeeByID(ID);

            return beepoEmployeeByID;
        }
    }
}
