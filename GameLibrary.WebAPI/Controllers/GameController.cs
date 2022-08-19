using GameLibrary.Models.GameModels;
using GameLibrary.Services.Game;
using Microsoft.AspNetCore.Mvc;

namespace GameLibrary.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private readonly IGameServices _gameServices;
        public GameController(IGameServices gameServices)
        {
            _gameServices = gameServices;
        }

        [HttpPost]
        public async Task<IActionResult> CreateGame([FromBody] CreateGame game)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (await _gameServices.CreateGameAsync(game))
                return Ok("Your game has been added to the database.");

            return BadRequest("Your game could not be added to the database.");
        }

        [HttpGet]
        public async Task<IActionResult> GetAllGamesAsync()
        {
            var allGames = await _gameServices.GetAllGames();
            return Ok(allGames);
        }

        [HttpGet("{Title:string")]
        public async Task<IActionResult> GetGameListByTitle([FromRoute] string gameTitle)
        {
            var gamesByTitle = await _gameServices.GetGameByTitleAsync(gameTitle);
            return Ok(gamesByTitle);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateGame([FromBody] GameUpdate gameId)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return await _gameServices.UpdateGameAsync(gameId) ? Ok($"The game with the id:{gameId} has been updated successfully.") : BadRequest($"The game with the id:{gameId} could not be updated...");
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteGame([FromRoute] int id)
        {
            return await _gameServices.DeleteGameAsync(id) ? Ok($"The game with the id:{id} has been deleted successfully.") : BadRequest($"The post with the id:{id} could not be deleted.");
        }
    }
}