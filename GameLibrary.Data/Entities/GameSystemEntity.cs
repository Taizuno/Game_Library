using System.ComponentModel.DataAnnotations;

namespace GameLibrary.Data.Entities
{
    public class GameSystemEntity
    {
        [Key]
        public int Id { get; set; }
        public string SystemName { get; set; }
        public string Manufacturer { get; set; }
        public int MaxPlayers { get; set; }
        public string GameSystemAvailability { get; set; }
    }
}