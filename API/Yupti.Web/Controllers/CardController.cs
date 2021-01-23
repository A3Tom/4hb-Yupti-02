using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Yupti.Data.Models;
using Yupti.Data.Repositories;

namespace Yupti.Web.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class CardController : ControllerBase
    {
        private readonly IPlannerRepository _plannerRepository;

        public CardController(IPlannerRepository plannerRepository)
        {
            _plannerRepository = plannerRepository;
        }


        [HttpGet]
        public async Task<IActionResult> GetCard(int cardId)
        {
            var result = await _plannerRepository.GetCardById(cardId);

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> AddCard(Card newCard)
        {
            var result = await _plannerRepository.AddCard(newCard);

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> AddWorklogEventForCard(WorklogEvent newEvent)
        {
            var result = await _plannerRepository.AddNewWorklogEvent(newEvent);

            return Ok(result);
        }


    }
}
