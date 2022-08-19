namespace GameLibrary.Models.GameModels
{
    public class GameDetail
    {
        public int Id { get; set; }
        public string GameTitle { get; set; }
        public string Description { get; set; }
        public string Developer { get; set; }
        public DateTime ReleaseDate { get; set; }

        public int GameGenre { get; set; }


        public int GameSystemAvailability { get; set; }
    }
}