using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.RepositoryInterfaces
{

    public interface IRepositoryManager
    {
        IDiscussionRepository DiscussionRepository { get; }

        //more repositories here

    }
}
