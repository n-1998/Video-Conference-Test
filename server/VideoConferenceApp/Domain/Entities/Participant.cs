using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public enum ParticipantRole
    {
        Judge,
        AppellateParty,
        RespondingParty,
        Representative
    }

    public class Participant : BaseEntity
    {
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public ParticipantRole Role { get; set; }
        public string? Email { get; set; }

        // Additional properties...
    }
}
