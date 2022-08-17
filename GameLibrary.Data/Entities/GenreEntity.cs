using System.ComponentModel.DataAnnotations;

namespace GameLibrary.Data.Entities
{
    public class GenreEntity
    {
        [Key]
        public int Id { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
        public bool IsKidFriendly { get; set; }
    }
}