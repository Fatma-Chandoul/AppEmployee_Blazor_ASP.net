using AutoMapper;
using BlazorApp_EmployeesNET6.ViewModels;
using Models;

namespace BlazorApp_EmployeesNET6.Data
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<Employee, EditEmployeeModel>()
                .ForMember(dest => dest.ConfirmEmail,
                           opt => opt.MapFrom(src => src.Email));
            CreateMap<EditEmployeeModel, Employee>();
        }
    }
}
