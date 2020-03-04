using AutoMapper;
using Interviews.Common.Dependencies.UnitOfWork;
using Interviews.Data;
using Interviews.Services.Base;
using Interviews.Services.Models.Security;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Interviews.Services.Domain
{
    public interface IUsersService : IService
    {

    }

    public class UsersService : Service, IUsersService
    {
        public UsersService(IRepositoryFactory repositoryFactory, IUnitOfWork unitOfWork, IMapper mapper) : 
            base(repositoryFactory, unitOfWork, mapper) { }
    }
}
