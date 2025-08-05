using Business.Interfaces;
using Entity.Dtos;
using Entity.Models;
using Entity.SpecificsDtos;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers.Implementations
{
    public class DeckController : BaseModelController<Deck, DeckDto>
    {
        private readonly IDeckBusiness _business;
        public DeckController(IDeckBusiness business) : base(business)
        {
            _business = business;
        }

        [HttpPost("GetAllPlayersDecksByGamePlayerIds")]
        public async Task<ActionResult<List<PlayersDeckDto>>> GetAllPlayersDecksByGamePlayerIds(List<int> playersIds)
        {
            try
            {
                List<PlayersDeckDto> playersWithDecks = await _business.GetAllPlayersDecksByGamePlayerIds(playersIds);
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
