using Interviews.Data.Repositories;
using Interviews.Data.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interviews.Data
{
    public interface IRepositoryFactory
    {
        T GetInstance<T>() where T : IRepository;
        IUsersRepository UsersRepository { get; }
        IInterviewsRepository InterviewsRepository { get; }
        IInterviewTypesRepository InterviewTypesRepository { get; }
        ITechnologiesRepository TechnologiesRepository { get; }
        IRecruiterProcessesRepository RecruiterProcessesRepository { get; }
        IRecruiterProcessTechnologiesRepository RecruiterProcessTechnologiesRepository { get; }
        IApplicantsRepository ApplicantsRepository { get; }
    }

    public class RepositoryFactory : IRepositoryFactory
    {
        private readonly IServiceProvider _provider;


        public RepositoryFactory(IServiceProvider provider)
        {
            _provider = provider;
        }

        public T GetInstance<T>() where T : IRepository
        {
            return (T)_provider.GetService(typeof(T));
        }

        public IUsersRepository UsersRepository => GetInstance<IUsersRepository>();
        public IInterviewsRepository InterviewsRepository => GetInstance<IInterviewsRepository>();
        public IInterviewTypesRepository InterviewTypesRepository => GetInstance<IInterviewTypesRepository>();
        public ITechnologiesRepository TechnologiesRepository => GetInstance<ITechnologiesRepository>();
        public IRecruiterProcessesRepository RecruiterProcessesRepository => GetInstance<IRecruiterProcessesRepository>();
        public IRecruiterProcessTechnologiesRepository RecruiterProcessTechnologiesRepository => GetInstance<IRecruiterProcessTechnologiesRepository>();
        public IApplicantsRepository ApplicantsRepository => GetInstance<IApplicantsRepository>();
    }
}
