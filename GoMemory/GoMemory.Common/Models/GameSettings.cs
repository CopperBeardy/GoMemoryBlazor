using GoMemory.Common.Enums;


namespace GoMemory.Common.Models
{

    public class GameSettings
    {
        public GameType GameType { get; set; }
        public Difficulty Difficulty { get; set; }
        public int GridRowSize { get; set; }
        public int GridColumnSize { get; set; }
        public int MaxSelectable { get; set; }
        public int MaxLevel { get; set; }
        public int CurrentLevel { get; set; }
        public int MatchesNeeded { get; set; }
        

    }
}