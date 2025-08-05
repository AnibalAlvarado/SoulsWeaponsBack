using Business.Interfaces;
using Entity.Dtos;
using Entity.Models;
using Entity.SpecificsDtos;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers.Implementations
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoomController : BaseModelController<Room, RoomDto>
    {
        private readonly IRoomBusiness _business;
        public RoomController(IRoomBusiness business) : base(business)
        {
            _business = business;
        }

        /// <summary>
        ///Create a new room and assign players their cards
        /// </summary>
        /// <param name="dto">List of players in the room</param>
        /// <returns></returns>
        [HttpPost("CreateRoom")]
        public async Task<ActionResult<List<PlayersDeckDto>>> CreateRoom(List<PlayerDto> players)
        {
            try
            {
                List<PlayersDeckDto> playersWithDecks = await _business.CreateRoom(players);
                var response = new ApiResponse<IEnumerable<PlayersDeckDto>>(playersWithDecks, true, "Registro almacenado exitosamente", null!);

                return Ok(response);
            }
            catch (Exception ex)
            {
                var response = new ApiResponse<IEnumerable<PlayersDeckDto>>(null!, false, ex.Message, null!);
                return StatusCode(StatusCodes.Status500InternalServerError, response);
            }
        }

    }
}
