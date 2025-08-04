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
    public class RoomData : BaseModelData<Room>, IRoomData
    {
        public RoomData(ApplicationDbContext context, IConfiguration configuration) : base(context, configuration)
        {
        }
    }
}
