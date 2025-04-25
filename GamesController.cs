using Microsoft.AspNetCore.Mvc;
using MIDTERM_A1_SLOT_MACHINE_BACKEND.Services;
using System;

namespace MIDTERM_A1_SLOT_MACHINE_BACKEND.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        private readonly GameService _gameService;

        public GamesController(GameService gameService)
        {
            _gameService = gameService;
        }

        // POST /save-game
        [HttpPost("save-game")]
        public IActionResult SaveGame([FromBody] GameResultDTO gameResult)
        {
            try
            {
                _gameService.SaveGameResult(gameResult);
                return Ok("Game result saved successfully.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET /games
        [HttpGet("games")]
        public IActionResult GetGames([FromQuery] DateTime startDate, [FromQuery] DateTime endDate)
        {
            var games = _gameService.GetGameResults(startDate, endDate);
            return Ok(games);
        }
    }
}
