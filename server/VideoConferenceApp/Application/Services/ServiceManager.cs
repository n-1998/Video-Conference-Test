using Application.Interfaces;
using Domain.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<IDiscussionService> _lazyDiscussionService;
        public ServiceManager(IRepositoryManager repositoryManager)
        {
            _lazyDiscussionService = new Lazy<IDiscussionService>(() => new DiscussionService(repositoryManager));
            //more services here
        }
        public IDiscussionService DiscussionService => throw new NotImplementedException();
    }
}
