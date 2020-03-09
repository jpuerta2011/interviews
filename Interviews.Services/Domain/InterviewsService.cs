using AutoMapper;
using Interviews.Common.Dependencies.UnitOfWork;
using Interviews.Common.Exceptions;
using Interviews.Data;
using Interviews.Services.Base;
using Interviews.Services.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Interviews.Services.Domain
{
    public interface IInterviewsService : IService
    {
        Task<ResponseModel<long>> ScheduleInterviewAsync(long userId, Models.Interviews interviewModel);
        Task<IEnumerable<Models.Interviews>> GetInterviewsAsync(long userId, DateTime date);
    }

    public class InterviewsService : Service, IInterviewsService
    {
        public InterviewsService(IRepositoryFactory repositoryFactory, IUnitOfWork unitOfWork, IMapper mapper)
            : base(repositoryFactory, unitOfWork, mapper)
        {

        }

        public async Task<ResponseModel<long>> ScheduleInterviewAsync(long userId, Models.Interviews interviewModel)
        {
            var respose = new ResponseModel<long>();

            if(interviewModel.Applicant == null || interviewModel.Applicant?.ApplicantId == 0)
            {
                throw new BadRequestCustomException("Debe indicar la persona ser entrevistada", "");
            }

            if(interviewModel.Date == DateTime.MinValue || interviewModel.Date < DateTime.Now)
            {
                throw new BadRequestCustomException("Debe indicar una fecha valida, debe ser una fecha futura", "");
            }

            if(interviewModel.InterviewTypeId == 0)
            {
                throw new BadRequestCustomException("Debe indicar el tipo de entrevista", "");
            }

            var interviewType = await Repositories.InterviewTypesRepository.GetSingleByIdAsync(interviewModel.InterviewTypeId);
            if (interviewType == null)
            {
                throw new NotFoundCustomException($"No se encontro el tipo de entrevista {interviewModel.InterviewTypeId}", "");
            }

            if (interviewModel.RecruiterProcessId == 0)
            {
                throw new BadRequestCustomException("Debe indicar el tipo de entrevista", "");
            }

            var recruiterProcess = await Repositories.RecruiterProcessesRepository.GetSingleAsync(r => r.RecruiterProcessId == interviewModel.RecruiterProcessId
                && r.UserId == userId);

            if (recruiterProcess == null)
            {
                throw new NotFoundCustomException($"No se encontro el proceso de contratación {interviewModel.RecruiterProcessId}", "");
            }

            var interviews = await Repositories.InterviewsRepository.ListAsync(i => i.Date == interviewModel.Date
                || i.Date.AddHours(1) > interviewModel.Date);

            if (interviews.ToList().Count > 0)
            {
                throw new BadRequestCustomException("Fecha de entrevista no valida", "La fecha debe tener una difrencia de por lo menos 1 hora con otras entrevista");
            }

            var applicant = await Repositories.ApplicantsRepository.GetSingleByIdAsync(interviewModel.Applicant.ApplicantId);

            if(applicant == null)
            {
                applicant = Mapper.Map<Data.Entities.Applicants>(interviewModel.Applicant);
                // Create an applicant if not exist
                Repositories.ApplicantsRepository.Save(applicant);
            }

            var interview = Mapper.Map<Data.Entities.Interviews>(interviewModel);
            interview.Applicant = applicant;
            interview.State = true;
            Repositories.InterviewsRepository.Save(interview);
            await UnitOfWork.CommitAsync();

            respose.Success = true;
            respose.Data = interview.InterviewId;
            return respose;
        }

        public async Task<IEnumerable<Models.Interviews>> GetInterviewsAsync(long userId, DateTime date)
        {
            var interviews = await Repositories.InterviewsRepository.ListAsync(i => i.RecruiterProcess.UserId == userId && i.Date.Subtract(date).Days == 0);
            interviews = interviews.OrderBy(d => d.Date);
            return Mapper.Map<IEnumerable<Models.Interviews>>(interviews);
        }
    }
}
