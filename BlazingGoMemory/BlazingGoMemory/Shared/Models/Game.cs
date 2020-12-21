using BlazingGoMemory.Shared.Enums;
using BlazingGoMemory.Shared.Helpers;
using System.Collections.Generic;


namespace BlazingGoMemory.Shared.Models
{
    public class Game
    {
        public int CurrentLevel { get; set; }
        public GameSettings GameSettings { get; set; } 
        public List<Token> TokensToRemember { get; set; }
        
        public List<Token> TokensSelected { get; set; }
        public List<Token> AllTokens { get; set; }
        public GameStage GameStage { get; set; } 


        public Game()
        {
            CurrentLevel = 0;
            GameSettings =   GameSettingsHelper.SetDifficulty(ModeDifficulty.Normal);            
            TokensToRemember = new List<Token>();          
            TokensSelected = new List<Token>();
            GameStage = GameStage.None;
            
        }
        
    public    void ResetGame()
    {
        CurrentLevel = 0;
        GameStage = GameStage.None;
    }
        public void ResetLevel()
    {
        GameStage = GameStage.Memorize;
        SetTokens();
    }
public void NextLevel(bool status)
    {

        _ = status switch
        {
            true => CurrentLevel++,
            false => CurrentLevel--
        };
        GameStage = GameStage.Memorize;
        SetTokens();
    }
    public void SetTokens()
    {
        AllTokens = TokenHelper.ToMatchTokenList(GameSettings.MaxTokens, TokenHelper.GetAllTokens());
        TokensToRemember = TokenHelper.ToMatchTokenList(CurrentLevel + 2, AllTokens);
        TokensToRemember = TokenHelper.ShuffleCollection(TokensToRemember);
    }
public void CheckFlag(bool success)
    {
        TokensSelected = new List<Token>();
        if (success)
        {
            if (CurrentLevel == GameSettings.MaxLevel)
            {
                GameStage = GameStage.CompleteMode;
            }
            else
            {
               GameStage = GameStage.LevelComplete;
            }
        }
        else
        {
            GameStage = GameStage.FailLevel;
        }
       
    }
       
    }
}
