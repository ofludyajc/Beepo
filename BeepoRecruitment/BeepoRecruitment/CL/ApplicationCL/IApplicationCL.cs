using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeepoRecruitment.Infrastructure.Dto;

namespace BeepoRecruitment.CL.ApplicationCL
{
    public interface IApplicationCL
    {
        Task<List<ApplicationInformationDto>> GetApplicationInformation();

        Task<ApplicationInformationDto> GetApplicationInformationByID(string ID);

        //Task<ApplicationInformationDto> CreateNewApplication(ApplicationInformationDto applicationInformationDto);
    }
}
