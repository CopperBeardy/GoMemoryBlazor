using GoMemory.Common.Enums;


namespace GoMemory.Common.Models
{
   
    public class DifficultySetting
    {  
    
        public GameType GameType { get; set; }
        public Difficulty Difficulty { get; set; }
        public int GridRowSize { get; set; }
        public int GridColumnSize { get; set; }
        public int MaxSelectable { get; set; }
        public int MaxLevel { get; set; }


       
        

    }
}