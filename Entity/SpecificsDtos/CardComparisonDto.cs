using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.SpecificsDtos
{
    public class CardComparisonDto
    {
        public int AbsoluteWinnerId { get; set; }
        public int? RoomId { get; set; }
        public string AttributeComparison { get; set; }
        public int? WinnerRoundId { get; set; }
        public int? WinnerCardId { get; set; }
        public List<PlayersSelectedCardsDto>? PlayersSelectedCards { get; set; }
    }
}
