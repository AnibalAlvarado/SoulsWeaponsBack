using Business.Interfaces;
using Entity.Dtos;
using Entity.Models;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers.Implementations
{
    [ApiController]
    [Route("api/[controller]")]
    public class GamePlayerController : BaseModelController<GamePlayer, GamePlayerDto>
    {
        public GamePlayerController(IGamePlayerBusiness business) : base(business)
        {
        }
    }
}
