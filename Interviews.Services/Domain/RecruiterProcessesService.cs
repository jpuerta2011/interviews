using AutoMapper;
using Interviews.Common.Dependencies.UnitOfWork;
using Interviews.Data;
using Interviews.Services.Base;
using Interviews.Services.Models;
using System.Threading.Tasks;
using System.Linq;
using Entities = Interviews.Data.Entities;
using System.Collections.Generic;

namespace Interviews.Services.Domain
{
    public interface IRecruiterProcessesService : IService
    {

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

        public async Task<ResponseModel<long>> CreateRecruiterProcess(RecruiterProcesses recruiterProcesses)
        {
            var response = new ResponseModel<long>();

            if(recruiterProcesses.Technologies == null && recruiterProcesses.Technologies.Count == 0)
            {
                response.Messages.Add("Debe indicar las tecnologias del proceso de reclutamiento");
                response.Success = false;
                return response;
            }

            if (string.IsNullOrEmpty(recruiterProcesses.Description))
            {
                response.Messages.Add("Debe indicar la descriptción del proceso");
                response.Success = false;
                return response;
            }

            var process = Mapper.Map<Entities.RecruiterProcesses>(recruiterProcesses);

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
