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
    public interface IRoomBusiness : IBaseModelBusiness<Room, RoomDto>
    {
        Task<List<PlayersDeckDto>> CreateRoom(List<PlayerDto> players);
        Task<CardComparisonDto> CardComparison(CardComparisonDto cards);
    }
}
