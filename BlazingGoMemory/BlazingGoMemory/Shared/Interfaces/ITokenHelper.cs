using BlazingGoMemory.Shared.Models;
using System;
using System.Collections.Generic;

namespace BlazingGoMemory.Shared.Interfaces
{
    public interface ITokenHelper
    {
     
        List<Token> GetShuffledTokens(int totalToken);
        List<Token> ShuffleCollection(List<Token> tokens);
        List<Token> ToMatchTokenList(int numberOfTokensNeeded, List<Token> tokens);

    }
}
