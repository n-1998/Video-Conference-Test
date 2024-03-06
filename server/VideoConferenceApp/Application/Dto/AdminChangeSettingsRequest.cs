using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto
{
    public class AdminChangeSettingsRequest
    {
        public bool MuteAll { get; set; }
        public bool TurnCameraOf { get; set; }
    }
}
