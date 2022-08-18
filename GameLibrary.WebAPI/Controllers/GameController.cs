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
        public async Task<IActionResult> CreateGame()
        { }
    }
}