using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities = Interviews.Data.Entities;
using Models = Interviews.Services.Models;

namespace Interviews.Api.Automapper
{
    public class EntityToModelMapperProfile : Profile
    {
        public EntityToModelMapperProfile()
        {
            CreateMap<Entities.Users, Models.Users>()
                .ForMember(d => d.Password, opt => opt.Ignore());

            CreateMap<Entities.RecruiterProcessTechnologies, Models.RecruiterProcessTechnologies>()
                .ForMember(d => d.TechnologyName, opt => opt.MapFrom(s => s.Technology.Name));

            CreateMap<Entities.RecruiterProcesses, Models.RecruiterProcesses>()
                .ForMember(d => d.Technologies, opt => opt.MapFrom(s => s.RecruiterProcessTechnologies))
                .ForMember(d => d.ParentTechnologyName, opt => opt.MapFrom(s => s.ParentTechnology.Name))
                .ForMember(d => d.InterviewsCount, opt => opt.MapFrom(s => (s.Interviews != null) ? s.Interviews.Count : 0));

            CreateMap<Entities.Interviews, Models.Interviews>()
                .ForMember(d => d.Applicant, opt => opt.Ignore())
                .ForMember(d => d.InterviewTypeName, opt => opt.MapFrom(s => s.InterviewType.Name))
                .ForMember(d => d.ApplicantName, opt => opt.MapFrom(s => s.Applicant.Name));

            CreateMap<Entities.Applicants, Models.Applicants>();

            CreateMap<Entities.Technologies, Models.Technologies>();
        }
    }
}
