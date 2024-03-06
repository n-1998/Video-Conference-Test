using Application.Common;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto
{

    public class ParticipantDto
    {
        //TODO add validations
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public ParticipantRole Role { get; set; }
        public string? Email { get; set; }
        public Permission Permission { get; set; }
        //more properties...
    }
}
