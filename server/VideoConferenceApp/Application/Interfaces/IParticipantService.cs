using Application.Common;
using Application.Dto;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IParticipantService
    {
        ParticipantDto GetParticipant(int id);
        IEnumerable<ParticipantDto> GetAll();

        Permission GetPermissionFromRole(ParticipantRole role);
    }
}
