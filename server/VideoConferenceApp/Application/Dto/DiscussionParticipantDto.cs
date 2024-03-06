using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto
{

    public class DiscussionParticipantDto
    {
        public long DiscussionId { get; set; }
        public long ParticipantId { get; set; }
        public ParticipantSettingsDto? Settings { get; set; }

    }
}
