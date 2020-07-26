using GoMemory.Common.Models;
using System;
using System.Collections.Generic;

namespace GoMemory.Common.Interfaces
{
    public interface IImageHelper
    {
        List<ImageTile> GetImages(int totalImages);
        List<ImageTile> ShuffleCollection(List<ImageTile> images);
        List<ImageTile> ToMatchImageTileList(int numberOfImagesNeeded, List<ImageTile> images);

    }
}
