


using GoMemory.Common.Interfaces;

namespace GoMemory.Common.Models
{
    public class OrderedGame : IGameModel
    {
       public int Level { get; set; }
        public int MatchesNeeded { get; set; } = 2;
    }
}
