using AutoMapper;
using Interviews.Common.Dependencies.UnitOfWork;
using Interviews.Data;
using Interviews.Services.Base;
using Interviews.Services.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Interviews.Services.Domain
{
    public interface ITechnologiesService : IService
    {
        Task<IEnumerable<Technologies>> GetParentTechnologiesAsync();
        Task<IEnumerable<Technologies>> GetChildrenTechnologiesAsync(long parentTechnologyId);
    }

    public class TechnologiesService : Service, ITechnologiesService
    {
        public TechnologiesService(IRepositoryFactory repositoryFactory, IUnitOfWork unitOfWork, IMapper mapper)
            :base(repositoryFactory, unitOfWork, mapper)
        {

        }

        public async Task<IEnumerable<Technologies>> GetParentTechnologiesAsync()
        {
            var parentsTechnologies = await Repositories.TechnologiesRepository.ListAsync(t => !t.ParentTechnologyId.HasValue);
            return Mapper.Map<IEnumerable<Technologies>>(parentsTechnologies);
        }

        public async Task<IEnumerable<Technologies>> GetChildrenTechnologiesAsync(long parentTechnologyId)
        {
            var childrenTechnologies = await Repositories.TechnologiesRepository
                .ListAsync(t => t.ParentTechnologyId.HasValue && t.ParentTechnologyId == parentTechnologyId);
            return Mapper.Map<IEnumerable<Technologies>>(childrenTechnologies);
        }

    }
}
