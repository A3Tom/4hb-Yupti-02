using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Yupti.Data.Models;
using Yupti.Data.Repositories;

namespace Yupti.Web.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class PlannerController : ControllerBase
    {
        private readonly IPlannerRepository _plannerRepository;

        public PlannerController(IPlannerRepository plannerRepository)
        {
            _plannerRepository = plannerRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBoards()
        {
            var result = await _plannerRepository.GetAllBoards();

            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> LoadAllBoardData(int boardId)
        {
            var result = await _plannerRepository.LoadFullBoardDataById(boardId);

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> AddNewBoard(Board newBoard)
        {
            var result = await _plannerRepository.AddBoard(newBoard);

            return Ok(result);
        }
    }
}
