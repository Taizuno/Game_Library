using System.ComponentModel.DataAnnotations;

namespace GameLibrary.Models.GameModels
{
    public class GameUpdate
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string GameTitle { get; set; }
        [Required]
        public string Description { get; set; }
        public string Developer { get; set; }
        public DateTime ReleaseDate { get; set; }

        public int GameGenre { get; set; }
        public int GameSystemAvailability { get; set; }

    }
}