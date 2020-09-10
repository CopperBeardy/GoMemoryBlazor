using System;
using System.Collections.Generic;
using System.Text;

namespace BlazingGoMemory.Shared.Models
{
    public class Game
    {
        public int CurrentLevel { get; set; }
        public GameSettings GameSettings { get; set; } 
        public List<Token> TokensToRemember { get; set; }
        
        public List<Token> TokensSelected { get; set; }

        public Game()
        {
            CurrentLevel = 0;
            GameSettings = new GameSettings();            
            TokensToRemember = new List<Token>();          
            TokensSelected = new List<Token>();
        }
    }
}
