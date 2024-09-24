using AutoMapper;
using BAL.ViewModel;
using DAL.Repositories.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Student, StudentReadVm>();
            CreateMap<StudentAddVm, Student>();
            CreateMap<StudentUpdateVm, Student>();
        }
    }
}
