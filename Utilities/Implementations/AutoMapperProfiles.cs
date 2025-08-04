using AutoMapper;
using Entity.Dtos;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Implementations
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles() : base()
        {
            CreateMap<Card, CardDto>().ReverseMap();
            CreateMap<Player, PlayerDto>().ReverseMap();
            CreateMap<GamePlayer, GamePlayerDto>().ReverseMap();
            CreateMap<Room,RoomDto>().ReverseMap();
            CreateMap<Deck, DeckDto>().ReverseMap();
        }
    }
}
