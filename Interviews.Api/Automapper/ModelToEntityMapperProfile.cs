using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities = Interviews.Data.Entities;
using Models = Interviews.Services.Models;

namespace Interviews.Api.Automapper
{
    public class ModelToEntityMapperProfile : Profile
    {
        public ModelToEntityMapperProfile()
        {
            CreateMap<Models.Users, Entities.Users>()
                .ForMember(d => d.RecruiterProcesses, opt => opt.Ignore())
                .ForMember(d => d.Password, opt => opt.Ignore());

            CreateMap<Models.RecruiterProcesses, Entities.RecruiterProcesses>()
                .ForMember(d => d.RecruiterProcessTechnologies, opt => opt.Ignore())
                .ForMember(d => d.ParentTechnology, opt => opt.Ignore())
                .ForMember(d => d.User, opt => opt.Ignore())
                .ForMember(d => d.Interviews, opt => opt.Ignore());

            CreateMap<Models.Interviews, Entities.Interviews>()
                .ForMember(d => d.Applicant, opt => opt.Ignore());

            CreateMap<Models.Applicants, Entities.Applicants>();
        }
    }
}
