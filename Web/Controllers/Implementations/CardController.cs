using Business.Interfaces;
using Entity.Dtos;
using Entity.Models;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers.Implementations
{
    [ApiController]
    [Route("api/[controller]")]
    public class CardController : BaseModelController<Card, CardDto>
    {
        public CardController(ICardBusiness business) : base(business)
        {
        }
    }
}
