using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto
{
    public class ParticipantSettings : BaseEntity
    {
        public bool isMuted { get; set; }
        public bool isCameraActive { get; set; }
        public bool isPresenting { get; set; }
    }
}
