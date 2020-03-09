using Interviews.Services.Base;
using Interviews.Services.Domain;
using Interviews.Services.Domain.Security;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interviews.Services
{
    public interface IServiceFactory
    {
        T GetInstance<T>() where T : IService;
        ISecurityService SecurityService { get; }
        ITechnologiesService TechnologiesService { get; }
        IRecruiterProcessesService RecruiterProcessesService { get; }
        IInterviewsService InterviewsService { get; }
    }
    
    public class ServiceFactory : IServiceFactory
    {
        private readonly IServiceProvider _provider;

        public ServiceFactory(IServiceProvider provider)
        {
            _provider = provider;
        }        

        public T GetInstance<T>() where T : IService => (T)_provider.GetService(typeof(T));

        public ISecurityService SecurityService => GetInstance<ISecurityService>();

        public ITechnologiesService TechnologiesService => GetInstance<ITechnologiesService>();

        public IRecruiterProcessesService RecruiterProcessesService => GetInstance<IRecruiterProcessesService>();

        public IInterviewsService InterviewsService => GetInstance<IInterviewsService>();
    }
}
