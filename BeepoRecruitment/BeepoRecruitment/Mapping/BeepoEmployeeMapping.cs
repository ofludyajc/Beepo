using AutoMapper;
using BeepoRecruitment.Models;
using BeepoRecruitment.Infrastructure.Dto;

namespace BeepoRecruitment.Mapping
{
    public class BeepoEmployeeMapping : Profile
    {
        public BeepoEmployeeMapping()
        {
            CreateMap<BeepoEmployeeDto, BeepoEmployee>()
                .ForMember(dest => dest.EmployeeID, opt => opt.MapFrom(src => src.EmployeeID))
                .ForMember(dest => dest.EmployeeName, opt => opt.MapFrom(src => src.EmployeeName))
                .ForMember(dest => dest.EmployeeRole, opt => opt.MapFrom(src => src.EmployeeRole))
                .ForMember(dest => dest.EmployeePosition, opt => opt.MapFrom(src => src.EmployeePosition))
                .ForMember(dest => dest.ContactID, opt => opt.MapFrom(src => src.ContactID))
                .ForPath(dest => dest.Contact.ContactID, opt => opt.MapFrom(src => src.Contact.ContactID))
                .ForPath(dest => dest.Contact.EmailAddress, opt => opt.MapFrom(src => src.Contact.EmailAddress))
                .ForPath(dest => dest.Contact.MobileNumber, opt => opt.MapFrom(src => src.Contact.MobileNumber))
                .ForPath(dest => dest.Contact.PhysicalAddress, opt => opt.MapFrom(src => src.Contact.PhysicalAddress));

            CreateMap<BeepoEmployee, BeepoEmployeeDto>()
                .ForMember(dest => dest.EmployeeID, opt => opt.MapFrom(src => src.EmployeeID))
                .ForMember(dest => dest.EmployeeName, opt => opt.MapFrom(src => src.EmployeeName))
                .ForMember(dest => dest.EmployeeRole, opt => opt.MapFrom(src => src.EmployeeRole))
                .ForMember(dest => dest.EmployeePosition, opt => opt.MapFrom(src => src.EmployeePosition))
                .ForMember(dest => dest.ContactID, opt => opt.MapFrom(src => src.ContactID))
                .ForPath(dest => dest.Contact.ContactID, opt => opt.MapFrom(src => src.Contact.ContactID))
                .ForPath(dest => dest.Contact.EmailAddress, opt => opt.MapFrom(src => src.Contact.EmailAddress))
                .ForPath(dest => dest.Contact.MobileNumber, opt => opt.MapFrom(src => src.Contact.MobileNumber))
                .ForPath(dest => dest.Contact.PhysicalAddress, opt => opt.MapFrom(src => src.Contact.PhysicalAddress));
        }
    }
}
