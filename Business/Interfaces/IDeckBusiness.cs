using Entity.Dtos;
using Entity.Models;
using Entity.SpecificsDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IDeckBusiness : IBaseModelBusiness<Deck, DeckDto>
    {
        Task<List<PlayersDeckDto>> AssignCardsToPlayers(List<PlayersDeckDto> playersDeckDto);
    }
}
