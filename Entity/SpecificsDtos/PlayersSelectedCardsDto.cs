using Entity.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.SpecificsDtos
{
    public class PlayersSelectedCardsDto
    {
        public int GamePlayerId { get; set; }
        public CardDto? Card { get; set; }
    }
}
