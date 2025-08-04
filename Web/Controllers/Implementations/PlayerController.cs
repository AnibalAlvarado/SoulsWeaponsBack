using Business.Interfaces;
using Entity.Dtos;
using Entity.Models;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers.Implementations
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlayerController : BaseModelController<Player, PlayerDto>
    {
        public PlayerController(IPlayerBusiness business) : base(business)
        {
        }
    }
}
