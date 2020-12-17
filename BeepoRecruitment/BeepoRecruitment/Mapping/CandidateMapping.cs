using AutoMapper;
using BeepoRecruitment.Models;
using BeepoRecruitment.Infrastructure.Dto;

namespace BeepoRecruitment.Mapping
{
    public class CandidateMapping : Profile
    {
        public CandidateMapping()
        {
            CreateMap<CandidateDto, Candidate>()
                .ForMember(dest => dest.CandidateID, opt => opt.MapFrom(src => src.CandidateID))
                .ForMember(dest => dest.CandidateName, opt => opt.MapFrom(src => src.CandidateName))
                .ForMember(dest => dest.CandidateRole, opt => opt.MapFrom(src => src.CandidateRole))
                .ForMember(dest => dest.CandidatePosition, opt => opt.MapFrom(src => src.CandidatePosition))
                .ForMember(dest => dest.CandidateSalary, opt => opt.MapFrom(src => src.CandidateSalary))
                .ForMember(dest => dest.Remarks, opt => opt.MapFrom(src => src.Remarks))
                .ForPath(dest => dest.Contact.ContactID, opt => opt.MapFrom(src => src.Contact.ContactID))
                .ForPath(dest => dest.Contact.MobileNumber, opt => opt.MapFrom(src => src.Contact.MobileNumber))
                .ForPath(dest => dest.Contact.EmailAddress, opt => opt.MapFrom(src => src.Contact.EmailAddress))
                .ForPath(dest => dest.Contact.PhysicalAddress, opt => opt.MapFrom(src => src.Contact.PhysicalAddress))
                .ForPath(dest => dest.ApplicationInformation.ApplicationID, opt => opt.MapFrom(src => src.ApplicationInformation.ApplicationID))
                .ForPath(dest => dest.ApplicationInformation.EmployeeID, opt => opt.MapFrom(src => src.ApplicationInformation.EmployeeID))
                .ForPath(dest => dest.ApplicationInformation.CandidateID, opt => opt.MapFrom(src => src.CandidateID))
                .ForPath(dest => dest.ApplicationInformation.AppointmentName, opt => opt.MapFrom(src => src.ApplicationInformation.AppointmentName))
                .ForPath(dest => dest.ApplicationInformation.AppointmentDate, opt => opt.MapFrom(src => src.ApplicationInformation.AppointmentDate))
                .ForPath(dest => dest.ApplicationInformation.ApplicationStatus, opt => opt.MapFrom(src => src.ApplicationInformation.ApplicationStatus))
                .ForPath(dest => dest.ApplicationInformation.BeepoEmployee.EmployeeName, opt => opt.MapFrom(src => src.ApplicationInformation.BeepoEmployee.EmployeeName))
                .ForPath(dest => dest.ApplicationInformation.BeepoEmployee.EmployeeRole, opt => opt.MapFrom(src => src.ApplicationInformation.BeepoEmployee.EmployeeRole))
                .ForPath(dest => dest.ApplicationInformation.BeepoEmployee.EmployeePosition, opt => opt.MapFrom(src => src.ApplicationInformation.BeepoEmployee.EmployeePosition));

            CreateMap<Candidate, CandidateDto >()
                .ForMember(dest => dest.CandidateID, opt => opt.MapFrom(src => src.CandidateID))
                .ForMember(dest => dest.CandidateName, opt => opt.MapFrom(src => src.CandidateName))
                .ForMember(dest => dest.CandidateRole, opt => opt.MapFrom(src => src.CandidateRole))
                .ForMember(dest => dest.CandidatePosition, opt => opt.MapFrom(src => src.CandidatePosition))
                .ForMember(dest => dest.CandidateSalary, opt => opt.MapFrom(src => src.CandidateSalary))
                .ForMember(dest => dest.Remarks, opt => opt.MapFrom(src => src.Remarks))
                .ForPath(dest => dest.Contact.ContactID, opt => opt.MapFrom(src => src.Contact.ContactID))
                .ForPath(dest => dest.Contact.MobileNumber, opt => opt.MapFrom(src => src.Contact.MobileNumber))
                .ForPath(dest => dest.Contact.EmailAddress, opt => opt.MapFrom(src => src.Contact.EmailAddress))
                .ForPath(dest => dest.Contact.PhysicalAddress, opt => opt.MapFrom(src => src.Contact.PhysicalAddress))
                .ForPath(dest => dest.ApplicationInformation.ApplicationID, opt => opt.MapFrom(src => src.ApplicationInformation.ApplicationID))
                .ForPath(dest => dest.ApplicationInformation.EmployeeID, opt => opt.MapFrom(src => src.ApplicationInformation.EmployeeID))
                .ForPath(dest => dest.ApplicationInformation.CandidateID, opt => opt.MapFrom(src => src.CandidateID))
                .ForPath(dest => dest.ApplicationInformation.AppointmentName, opt => opt.MapFrom(src => src.ApplicationInformation.AppointmentName))
                .ForPath(dest => dest.ApplicationInformation.AppointmentDate, opt => opt.MapFrom(src => src.ApplicationInformation.AppointmentDate))
                .ForPath(dest => dest.ApplicationInformation.ApplicationStatus, opt => opt.MapFrom(src => src.ApplicationInformation.ApplicationStatus))
                .ForPath(dest => dest.ApplicationInformation.BeepoEmployee.EmployeeName, opt => opt.MapFrom(src => src.ApplicationInformation.BeepoEmployee.EmployeeName))
                .ForPath(dest => dest.ApplicationInformation.BeepoEmployee.EmployeeRole, opt => opt.MapFrom(src => src.ApplicationInformation.BeepoEmployee.EmployeeRole))
                .ForPath(dest => dest.ApplicationInformation.BeepoEmployee.EmployeePosition, opt => opt.MapFrom(src => src.ApplicationInformation.BeepoEmployee.EmployeePosition));
        }
    }
}
