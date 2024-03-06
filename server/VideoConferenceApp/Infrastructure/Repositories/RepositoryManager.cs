using Domain.Interfaces;
using Domain.RepositoryInterfaces;
using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public sealed class RepositoryManager : IRepositoryManager
    {
        private readonly Lazy<IDiscussionRepository> _lazyDiscussionRepository;
        //more repositories here

        public RepositoryManager(AppDbContext dbContext)
        {
            _lazyDiscussionRepository = new Lazy<IDiscussionRepository>(() => new DiscussionRepository(dbContext));
        }

        public IDiscussionRepository DiscussionRepository => _lazyDiscussionRepository.Value;
    }
}
