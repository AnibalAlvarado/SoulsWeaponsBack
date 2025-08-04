using Business.Interfaces;
using Entity.Dtos;
using Entity.Models;

namespace Web.Controllers.Implementations
{
    public class DeckController : BaseModelController<Deck, DeckDto>
    {
        public DeckController(IDeckBusiness business) : base(business)
        {
        }
    }
}
