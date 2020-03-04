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

            CreateMap<Entities.RecruiterProcesses, Models.RecruiterProcesses>()
                .ForMember(d => d.Technologies, opt => opt.Ignore());
        }
    }
}
