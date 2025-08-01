using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Dtos
{
    public class GamePlayerDto : BaseDto
    {
        public int PlayerId { get; set; }
        public int RoomId { get; set; }
        public bool? Winner { get; set; }

        public string? Player { get; set; }
        public string? Room { get; set; }
    }
}
