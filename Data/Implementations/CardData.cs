using Data.Interfaces;
using Entity.Contexts;
using Entity.Dtos;
using Entity.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Implementations
{
    public class CardData : BaseModelData<Card>, ICardData
    {
        public CardData(ApplicationDbContext context, IConfiguration configuration): base(context,configuration)
        {
        }
    }
}
