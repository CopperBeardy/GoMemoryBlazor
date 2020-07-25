using System;
using System.Collections.Generic;
using System.Text;


namespace GoMemory.Common.Interfaces
{
    public interface IGameModel
    {
        public int Level { get; set; }

        public int MatchesNeeded { get; set; }
    }
}
