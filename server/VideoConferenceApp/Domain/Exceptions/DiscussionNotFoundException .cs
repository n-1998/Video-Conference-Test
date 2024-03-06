using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions
{
    public sealed class DiscussionNotFoundException : NotFoundException
    {
        public DiscussionNotFoundException(Guid discussionId) : base($"{discussionId} was not found.")
        {
        }
    }
}
