using GoMemory.Shared.Models;

namespace GoMemory.Helpers
{
    public static class DifficultyHelper
    {
        public static GameSettings SetDifficulty(int columSize, int rowSize, int maxSelectable, int maxLevel)
        {
            return new GameSettings()
            {
                GridColumnSize = columSize,
                GridRowSize = rowSize,
                MaxSelectable = maxSelectable,
                MaxLevel = maxLevel
            };
        }
    }
}
