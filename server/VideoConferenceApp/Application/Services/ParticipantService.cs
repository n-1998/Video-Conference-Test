using Application.Common;
using Application.Dto;
using Application.Interfaces;
using Domain.Entities;
using Domain.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    internal class ParticipantService : IParticipantService
    {
        public IEnumerable<ParticipantDto> GetAll()
        {
            //map Participant result to ParticipantDto,
            //populate Permission using GetPermissionFromRole 
            throw new NotImplementedException();
        }

        public ParticipantDto GetParticipant(int id)
        {
            //map Participant result to ParticipantDto,
            //populate Permission using GetPermissionFromRole 
            throw new NotImplementedException();
        }

        public Permission GetPermissionFromRole(ParticipantRole role)
        {
            switch (role)
            {
                case ParticipantRole.Judge:
                    return Permission.Admin;
                default:
                    return Permission.User;
            }
        }

    }
}
