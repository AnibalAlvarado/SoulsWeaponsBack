using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Dtos
{
    public class DeckDto : BaseDto
    {
        public int GamePlayerId { get; set; }
        public int CardId { get; set; }

        public string? GamePlayer { get; set; }
        public string? Card { get; set; }
    }
}
