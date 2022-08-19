using GameLibrary.Models.GameModels;

namespace GameLibrary.Services.Game
{
    public interface IGameServices
    {
        Task<bool> CreateGameAsync(CreateGame gameData);
        Task<IEnumerable<GameListItem>> GetAllGames();
        Task<bool> UpdateGameAsync(GameUpdate request);
        Task<bool> DeleteGameAsync(int gameId);
        Task<IEnumerable<GameDetail>> GetGameByTitleAsync(string gameTitle);
    }
}