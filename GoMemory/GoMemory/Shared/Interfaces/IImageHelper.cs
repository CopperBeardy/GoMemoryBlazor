using GoMemory.Shared.Models;
using System;
using System.Collections.Generic;

namespace GoMemory.Shared.Interfaces
{
    public interface IImageHelper
    {
        List<ImageTile> GetImages(int totalImages);
        List<ImageTile> ShuffleCollection(List<ImageTile> images);
        List<ImageTile> ToMatchImageTileList(int numberOfImagesNeeded, List<ImageTile> images);

    }
}
