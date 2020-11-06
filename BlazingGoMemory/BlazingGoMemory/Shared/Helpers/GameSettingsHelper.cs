using BlazingGoMemory.Shared.Enums;
using BlazingGoMemory.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingGoMemory.Shared.Helpers
{
    public static class GameSettingsHelper
    {
        public static GameSettings SetDifficulty(ModeDifficulty modeDifficulty)
        {
            GameSettings settings = new GameSettings();
            switch (modeDifficulty)
            {
                case ModeDifficulty.Easy:
                    settings.Difficulty = ModeDifficulty.Easy;
                    settings.MaxLevel = 10;
                    settings.SurfaceSize = 4;
                    settings.MaxTokens = 16;
                    break;
                case ModeDifficulty.Normal:
                    settings.Difficulty = ModeDifficulty.Normal;
                    settings.MaxLevel = 20;
                    settings.SurfaceSize = 5;
                   settings.MaxTokens = 25;
                    break;
                case ModeDifficulty.Hard:
                    settings.Difficulty = ModeDifficulty.Hard;
                    settings.MaxLevel = 30;
                    settings.MaxTokens = 36;
                    settings.SurfaceSize = 6;
                    break;
                default:
                    break;
            }

            return settings;
        }
    }
}
