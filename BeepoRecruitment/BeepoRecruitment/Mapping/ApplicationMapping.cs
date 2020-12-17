using AutoMapper;
using BeepoRecruitment.Models;
using BeepoRecruitment.Infrastructure.Dto;

namespace BeepoRecruitment.Mapping
{
    public class ApplicationMapping : Profile
    {
        public ApplicationMapping()
        {
            CreateMap<ApplicationInformationDto, ApplicationInformation>()
                .ForMember(dest => dest.ApplicationID, opt => opt.MapFrom(src => src.ApplicationID))
                .ForMember(dest => dest.EmployeeID, opt => opt.MapFrom(src => src.EmployeeID))
                .ForMember(dest => dest.CandidateID, opt => opt.MapFrom(src => src.CandidateID))
                .ForMember(dest => dest.AppointmentName, opt => opt.MapFrom(src => src.AppointmentName))
                .ForMember(dest => dest.AppointmentDate, opt => opt.MapFrom(src => src.AppointmentDate))
                .ForMember(dest => dest.ApplicationStatus, opt => opt.MapFrom(src => src.ApplicationStatus))
                .ForPath(dest => dest.BeepoEmployee.EmployeeID, opt => opt.MapFrom(src => src.EmployeeID))
                .ForPath(dest => dest.BeepoEmployee.EmployeeName, opt => opt.MapFrom(src => src.BeepoEmployee.EmployeeName))
                .ForPath(dest => dest.BeepoEmployee.EmployeeRole, opt => opt.MapFrom(src => src.BeepoEmployee.EmployeeRole))
                .ForPath(dest => dest.BeepoEmployee.EmployeePosition, opt => opt.MapFrom(src => src.BeepoEmployee.EmployeePosition))
                .ForPath(dest => dest.BeepoEmployee.ContactID, opt => opt.MapFrom(src => src.BeepoEmployee.ContactID));

            CreateMap<ApplicationInformation, ApplicationInformationDto> ()
                .ForMember(dest => dest.ApplicationID, opt => opt.MapFrom(src => src.ApplicationID))
                .ForMember(dest => dest.EmployeeID, opt => opt.MapFrom(src => src.EmployeeID))
                .ForMember(dest => dest.CandidateID, opt => opt.MapFrom(src => src.CandidateID))
                .ForMember(dest => dest.AppointmentName, opt => opt.MapFrom(src => src.AppointmentName))
                .ForMember(dest => dest.AppointmentDate, opt => opt.MapFrom(src => src.AppointmentDate))
                .ForMember(dest => dest.ApplicationStatus, opt => opt.MapFrom(src => src.ApplicationStatus))
                .ForPath(dest => dest.BeepoEmployee.EmployeeID, opt => opt.MapFrom(src => src.EmployeeID))
                .ForPath(dest => dest.BeepoEmployee.EmployeeName, opt => opt.MapFrom(src => src.BeepoEmployee.EmployeeName))
                .ForPath(dest => dest.BeepoEmployee.EmployeeRole, opt => opt.MapFrom(src => src.BeepoEmployee.EmployeeRole))
                .ForPath(dest => dest.BeepoEmployee.EmployeePosition, opt => opt.MapFrom(src => src.BeepoEmployee.EmployeePosition))
                .ForPath(dest => dest.BeepoEmployee.ContactID, opt => opt.MapFrom(src => src.BeepoEmployee.ContactID));
        }
    }
}
