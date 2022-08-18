using GameLibrary.Data;
using GameLibrary.Data.Entities;
using GameLibrary.Models.GameModels;
using Microsoft.EntityFrameworkCore;

namespace GameLibrary.Services.Game
{
    public class GameServices : IGameServices
    {
        private readonly ApplicationDbContext _dbContext;

        public GameServices(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<IEnumerable<GameListItem>> GetAllGames()
        {
            var gameList = await _dbContext.Games
                    .Select(entity => new GameListItem
                    {
                        Id = entity.Id,
                        GameTitle = entity.GameTitle,
                        Description = entity.Description,
                        Developer = entity.Developer,
                        ReleaseDate = entity.ReleaseDate,
                        GameGenre = entity.GameGenre,
                        GameSystemAvailability = entity.GameSystemAvailability
                    })
                    .ToListAsync();

            return gameList;

        }
        public async Task<bool> CreateGameAsync(CreateGame gameData)
        {
            var gameEntity = new GameEntity
            {
                GameTitle = gameData.GameTitle,
                Description = gameData.Description,
                Developer = gameData.Developer,
                ReleaseDate = gameData.ReleaseDate

            };
            _dbContext.Games.Add(gameEntity);

            var numberOfChanges = await _dbContext.SaveChangesAsync();
            return numberOfChanges == 1;
        }
        public async Task<bool> UpdateGameAsync(GameUpdate request)
        {

            var gameEntity = await _dbContext.Games.FindAsync(request.Id);

            gameEntity.GameTitle = request.GameTitle;
            gameEntity.Description = request.Description;
            gameEntity.Developer = request.Developer;
            gameEntity.ReleaseDate = request.ReleaseDate;
            gameEntity.GameGenre = request.GameGenre;
            gameEntity.GameSystemAvailability = request.GameSystemAvailability;


            var numberOfChanges = await _dbContext.SaveChangesAsync();


            return numberOfChanges == 1;
        }
        public async Task<bool> DeleteGameAsync(int gameId)
        {
            var gameEntity = await _dbContext.Games.FindAsync(gameId);


            _dbContext.Games.Remove(gameEntity);
            return await _dbContext.SaveChangesAsync() == 1;


        }


    }
}