using BlazingGoMemory.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazingGoMemory.Shared.Models
{
    public class GameSettings
    {
        public int MaxLevel { get; set; }
        public int MaxTokens { get; set; }      
        public RecallStyle RecallStyle { get; set; }
        public ModeDifficulty Difficulty { get; set; }

        
    }
}
