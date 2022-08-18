namespace GameLibrary.Models.GameModels
{
    public class CreateGame
    {
        public string GameTitle { get; set; }
        public string Description { get; set; }
        public string Developer { get; set; }
        public DateTime ReleaseDate { get; set; }

    }
}