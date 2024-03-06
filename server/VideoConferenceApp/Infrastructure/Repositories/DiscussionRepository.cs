using Domain.Entities;
using Domain.Interfaces;
using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    internal class DiscussionRepository : IDiscussionRepository
    {
        private readonly AppDbContext _dbContext;

        public DiscussionRepository(AppDbContext dbContext) => _dbContext = dbContext;

        //example
        public void Add(Discussion discussion) => _dbContext.Discussions.Add(discussion);

        public Task<Discussion> Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Discussion>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DiscussionParticipant> getDiscussionParticipants(Guid discussionId)
        {
            throw new NotImplementedException();
        }

        public void Remove(Discussion entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Discussion entity)
        {
            throw new NotImplementedException();
        }
    }
}
