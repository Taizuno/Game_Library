using GameLibrary.Models.GameModels;

namespace GameLibrary.Services.Game
{
    public interface IGameServices
    {
        Task<bool> CreateGameAsync(CreateGame gameData);
    }
}