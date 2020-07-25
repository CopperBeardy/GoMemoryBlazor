using System;
using System.Collections.Generic;
using System.Text;


namespace GoMemory.Common.Interfaces
{
    public interface IGameModel
    {
       int Level { get; set; }

       int MatchesNeeded { get; set; }
    }
}
