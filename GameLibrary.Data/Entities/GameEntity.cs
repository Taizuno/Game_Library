using System.ComponentModel.DataAnnotations;

namespace GameLibrary.Data.Entities
{
    public class GameEntity
    {
        [Key]
        public int Id { get; set; }
        public string GameTitle { get; set; }
        public string Description { get; set; }
        public string ReleaseDate { get; set; }
        public GenreEntity Genre { get; set; }

    }
}