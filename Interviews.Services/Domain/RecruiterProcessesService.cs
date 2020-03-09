using AutoMapper;
using Interviews.Common.Dependencies.UnitOfWork;
using Interviews.Data;
using Interviews.Services.Base;
using Interviews.Services.Models;
using System.Threading.Tasks;
using System.Linq;
using Entities = Interviews.Data.Entities;
using System.Collections.Generic;
using Interviews.Common.Exceptions;

namespace Interviews.Services.Domain
{
    public interface IRecruiterProcessesService : IService
    {
        Task<IEnumerable<RecruiterProcesses>> GetRecruiterProcessesByUserIdAsync(long userId);
        Task<ResponseModel<RecruiterProcesses>> GetRecruiterProcess(long userId, long recruiterProcessId);
        Task<ResponseModel<long>> CreateRecruiterProcess(RecruiterProcesses recruiterProcesses, long userId);
    }

    public class RecruiterProcessesService : Service, IRecruiterProcessesService
    {
        public RecruiterProcessesService(IRepositoryFactory repositoryFactory, IUnitOfWork unitOfWork, IMapper mapper)
            :base(repositoryFactory, unitOfWork, mapper)
        {

        }

        public async Task<IEnumerable<RecruiterProcesses>> GetRecruiterProcessesByUserIdAsync(long userId)
        {
            var processes = await Repositories.RecruiterProcessesRepository.ListAsync(rp => rp.UserId == userId);
            return Mapper.Map<IEnumerable<RecruiterProcesses>>(processes);
        }

        public async Task<ResponseModel<RecruiterProcesses>> GetRecruiterProcess(long userId, long recruiterProcessId)
        {
            var process = await Repositories.RecruiterProcessesRepository.GetSingleAsync(p => p.UserId == userId && p.RecruiterProcessId == recruiterProcessId, new List<string> { "RecruiterProcessTechnologies", "RecruiterProcessTechnologies.Technology" });
            if (process == null) throw new NotFoundCustomException("No se encontro el proceso", "");
            return new ResponseModel<RecruiterProcesses>()
            {
                Data = Mapper.Map<RecruiterProcesses>(process),
                Success = true
            };
        }

        public async Task<ResponseModel<long>> CreateRecruiterProcess(RecruiterProcesses recruiterProcesses, long userId)
        {
            var response = new ResponseModel<long>();

            if(recruiterProcesses.Technologies == null && recruiterProcesses.Technologies.Count == 0)
            {
                throw new BadRequestCustomException("Debe indicar las tecnologias del proceso de reclutamiento", "");
            }

            if (string.IsNullOrEmpty(recruiterProcesses.Description))
            {
                throw new BadRequestCustomException("Debe indicar la descripción del proceso", "");
            }

            if(recruiterProcesses.ParentTechnologyId == 0)
            {
                throw new BadRequestCustomException("Debe indicar la tecnologia principal de proceso", "");
            }

            var parentTechnology = await Repositories.TechnologiesRepository.GetSingleByIdAsync(recruiterProcesses.ParentTechnologyId);
            if(parentTechnology == null)
            {
                throw new NotFoundCustomException("No se encontro la tecnologia del proceso", "");
            }

            var process = Mapper.Map<Entities.RecruiterProcesses>(recruiterProcesses);

            process.UserId = userId;
            process.State = true;
            process.RecruiterProcessTechnologies = recruiterProcesses.Technologies.Select(t => new Entities.RecruiterProcessTechnologies
            {
                TechnologyId = t.TechnologyId,
                State = true
            }).ToList();

            Repositories.RecruiterProcessesRepository.Save(process);

            await UnitOfWork.CommitAsync();

            response.Data = process.RecruiterProcessId;
            response.Success = true;

            return response;
        }
    }
}
