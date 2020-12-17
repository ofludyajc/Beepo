using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeepoRecruitment.Services.BeepoEmployeeService;
using BeepoRecruitment.Infrastructure.Dto;
using Microsoft.AspNetCore.Mvc;

namespace BeepoRecruitment.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BeepoEmployeeController : ControllerBase
    {
        private readonly IBeepoEmployeeService beepoEmployeeService;

        public BeepoEmployeeController(IBeepoEmployeeService beepoEmployeeService)
        {
            this.beepoEmployeeService = beepoEmployeeService;
        }

        [HttpGet("GetBeepoEmployees")]
        public async Task<ActionResult<IEnumerable<BeepoEmployeeDto>>> GetBeepoEmployees()
        {
            var result = await beepoEmployeeService.GetBeepoEmployees();

            return result;
        }

        [HttpGet("GetBeepoEmployee/{ID}")]
        public async Task<ActionResult<BeepoEmployeeDto>> GetBeepoEmployeeByID(int ID)
        {
            var result = await beepoEmployeeService.GetEmployeeByID(ID);

            return result;
        }
    }
}
