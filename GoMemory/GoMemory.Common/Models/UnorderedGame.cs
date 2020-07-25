

using GoMemory.Common.Interfaces;

namespace GoMemory.Common.Models
{
    public class UnorderedGame : IGameModel
    {
     
        public int Level { get; set; } = 0;
        public int MatchesNeeded { get; set ; } = 2;
    }
}
