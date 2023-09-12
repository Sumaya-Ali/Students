using AutoMapper;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OL = ObjectLayer;

namespace DataAccessLayer.Profiles
{
    public class StudentProfile : Profile
    {
        public StudentProfile()
        {
            CreateMap<OL::Student, Student>()
                .ForMember(dest => dest.Id,
                opt => opt.MapFrom(src => src.Id))

                .ForMember(dest => dest.FirstName,
                opt => opt.MapFrom(src => src.FirstName))

                .ForMember(dest => dest.LastName,
                opt => opt.MapFrom(src => src.LastName))

                .ForMember(dest => dest.Email,
                opt => opt.MapFrom(src => src.Email))

                .ForMember(dest => dest.Telephon,
                opt => opt.MapFrom(src => src.Telephon))

                .ForMember(dest => dest.BirthDay,
                opt => opt.MapFrom(src => src.BirthDay));

                //.ForMember(dest => dest.Id,
                //opt => opt.Ignore());

            CreateMap<Student, OL.Student>()
                .ForMember(dest => dest.Id,
                opt => opt.MapFrom(src => src.Id))

                .ForMember(dest => dest.FirstName,
                opt => opt.MapFrom(src => src.FirstName))

                .ForMember(dest => dest.LastName,
                opt => opt.MapFrom(src => src.LastName))

                .ForMember(dest => dest.Email,
                opt => opt.MapFrom(src => src.Email))

                .ForMember(dest => dest.Telephon,
                opt => opt.MapFrom(src => src.Telephon))

                .ForMember(dest => dest.BirthDay,
                opt => opt.MapFrom(src => src.BirthDay));
        }
    }
}
