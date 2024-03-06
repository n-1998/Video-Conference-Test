using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto
{
    public class ParticipantSettingsDto
    {
        public bool IsMuted { get; set; } = true;
        public bool IsCameraActive { get; set; } = false ;
        public bool IsPresenting { get; set; } = false;
    }
}
