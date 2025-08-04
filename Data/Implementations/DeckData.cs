using Data.Interfaces;
using Entity.Contexts;
using Entity.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Implementations
{
    public class DeckData : BaseModelData<Deck>, IDeckData
    {
        public DeckData(ApplicationDbContext context, IConfiguration configuration) : base(context, configuration)
        {
        }
    }
}
