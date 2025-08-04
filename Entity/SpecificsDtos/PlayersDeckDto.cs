using Entity.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.SpecificsDtos
{
    public class PlayersDeckDto
    {
        public int? RoomId { get; set; }
        public int GamePlayerId { get; set; }
        public string? PlayerName { get; set; }
        public List<CardDto>? Cards { get; set; } = new List<CardDto>();
    }
}
