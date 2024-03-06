using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{

    public class DiscussionParticipant : BaseEntity
    {
        [Key]
        [Required]
        public Guid DiscussionId { get; set; }
        [Key]
        [Required]
        public Guid ParticipantId { get; set; }

    }
}
