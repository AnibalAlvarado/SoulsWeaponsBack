using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class Deck : BaseModel
    {
        public int GamePlayerId { get; set; }
        public int CardId { get; set; }
        public bool? IsEarned { get; set; }
        
        public GamePlayer? GamePlayer { get; set; }
        public Card? Card { get; set; }
    }
}
