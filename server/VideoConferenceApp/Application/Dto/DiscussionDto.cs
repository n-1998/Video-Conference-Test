using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto
{
    public class DiscussionDto
    {
        public long Id { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z\u0590-\u05fe ]+$", ErrorMessage = "תווים בעברית ובאנגלית בלבד")]
        public string? Name { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public long CaseNumber { get; set; }
        [Required]
        public DateTime StartTime { get; set; }
        [Required]
        public DateTime EndTime { get; set; }
        public DateTime ActualStartTime { get; set; }
        public DateTime ActualEndTime { get; set; }
        public IEnumerable<DiscussionParticipantDto>? Participants { get; set; }    
    }
}
