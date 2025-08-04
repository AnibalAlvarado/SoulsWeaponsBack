using AutoMapper;
using Business.Interfaces;
using Data.Interfaces;
using Entity.Dtos;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Implementations
{
    public class CardBusiness : BaseModelBusiness<Card, CardDto>, ICardBusiness
    {
        private readonly ICardData _data;
        public CardBusiness(ICardData data, IMapper mapper) : base(data, mapper)
        {
            _data = data;
        }

    }
}
