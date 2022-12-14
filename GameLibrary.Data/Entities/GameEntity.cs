using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameLibrary.Data.Entities
{
    public class GameEntity
    {
        [Key]
        public int Id { get; set; }
        public string GameTitle { get; set; }
        public string Description { get; set; }
        public string Developer { get; set; }
        public DateTime ReleaseDate { get; set; }
        [ForeignKey(nameof(Genre))]
        public int GameGenre { get; set; }
        public GenreEntity Genre { get; set; }
        [ForeignKey(nameof(GameSystem))]
        public int GameSystemAvailability { get; set; }
        public GameSystemEntity GameSystem { get; set; }

    }
}