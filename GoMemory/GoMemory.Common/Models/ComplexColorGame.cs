
using GoMemory.Common.Interfaces;
using System;
using System.Collections.Generic;


namespace GoMemory.Common.Models
{
    public class ComplexColorGame : IGameModel
    {
       public int Level { get; set; }
        public int MatchesNeeded { get; set; } = 1;
  }
}
