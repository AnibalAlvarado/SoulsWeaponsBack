using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IDeckData : IBaseModelData<Deck>
    {
        Task<int> InactiveCardOfDeck(int cardId, int playerId);
    }
}
