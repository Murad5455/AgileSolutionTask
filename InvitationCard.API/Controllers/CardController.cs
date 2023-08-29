using InvitationCard.Business.Abstract;
using InvitationCard.Business.NewFolder;
using InvitationCard.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InvitationCard.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class CardController : ControllerBase
    {

        private ICardservice _cardService;

        public CardController(ICardservice cardService)
        {
            _cardService = cardService;
        }

        [Authorize]
        [HttpGet]
        public IActionResult Get()
        {
            var cards = _cardService.GetAllCard();
            return Ok(cards); // 200 + data
        }
        [Authorize]
        [HttpPost]
        public IActionResult Add([FromBody] Card card)
        {
            var validator = new ValidationService();

            var validationResult = validator.Validate(card);

            if (validationResult.IsValid)
            {
                var createCard = _cardService.CreateCard(card);
                return CreatedAtAction("Get", new { id = createCard.ID }, createCard);
            }

            foreach (var error in validationResult.Errors)
            {
                ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
            }
            return BadRequest(ModelState);
        }
    }
}
