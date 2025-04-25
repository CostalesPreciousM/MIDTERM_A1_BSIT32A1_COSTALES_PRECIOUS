using Microsoft.AspNetCore.Mvc;
using MIDTERM_A1_SLOT_MACHINE_BACKEND.Services;

namespace MIDTERM_A1_SLOT_MACHINE_BACKEND.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private readonly PlayerService _playerService;

        public PlayersController(PlayerService playerService)
        {
            _playerService = playerService;
        }

        // GET /validate-player?studentNumber=XXXXX
        [HttpGet("validate-player")]
        public IActionResult ValidatePlayer(string studentNumber)
        {
            var player = _playerService.ValidatePlayer(studentNumber);
            if (player == null)
                return BadRequest("Invalid student number");
            return Ok(player);
        }
    }
}
