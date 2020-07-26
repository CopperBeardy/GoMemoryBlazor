using GoMemory.Shared.Interfaces;
using GoMemory.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GoMemory.Helpers
{
    public class ImageHelper : IImageHelper
    {

        public List<ImageTile> _images;
        public List<string> ImageCollection => new List<string>
        {
               "apple.png",
                "beer.png",
                "bell.png",
                "bison.png",
                "cake.png",
                "camera.png",
               "carrot.png",
                "cheese.png",
                "chocolate.png",
                "clock.png",
                "codfish.png",
                "crab.png",
                "egg.png",
                "frog.png",
                "hammer.png",
                "lightbulb.png",
                "lightning.png",
                "lolly.png",
                "microphone.png",
                "milkshake.png",
                "orange.png",
                "parrot.png",
                "phone.png",
                "pig.png",
                "portobello.png",
                "rabbit.png",
                "robots.png",
                "sausage.png",
                "scissors.png",
                "spider.png",
                "star.png",
                "strawberry.png",
                "teapot.png",
                "wasp.png",
                "watermelon.png",
                "wine.png"

};
        public ImageHelper()
        {
            //Temporary generation
            foreach (var img in ImageCollection)
            {
                _images.Add(new ImageTile
                {
                    Source = $"../image/{img}",
                    Name = img.Replace(".png", string.Empty)
                });
            }
        }

        /// <summary>
        ///  Randomize the order of images that will be place for the player to select from
        /// </summary>
        /// <param name="totalImages"></param>
        /// <returns>List<ImageTile> </returns>
        public List<ImageTile> GetImages(int totalImages)
        {
            if (totalImages <= 0)
            {
                return null;
            }
            return ShuffleCollection(_images).Take(totalImages).ToList();
        }

        /// <summary>
        /// reorders list items to create a random order
        /// </summary>
        /// <param name="images"></param>
        /// <returns>List<ImageTile></returns>
        public List<ImageTile> ShuffleCollection(List<ImageTile> images)
        {
            Random rnd = new Random();
            List<ImageTile> unsorted = images;
            for (int i = 0; i < unsorted.Count; i++)
            {
                ImageTile temp = unsorted[i];
                int randomIndex = rnd.Next(0, unsorted.Count);
                unsorted[i] = unsorted[randomIndex];
                unsorted[randomIndex] = temp;
            }
            return unsorted;
        }



        /// <summary>
        ///    randomizing the order of the list of images that need to be match for games in which order is needed
        /// </summary>
        /// <param name="numberOfImagesNeeded"></param>
        /// <param name="images"></param>
        /// <returns>List<ImageTile></returns>
        public List<ImageTile> ToMatchImageTileList(int numberOfImagesNeeded, List<ImageTile> images)
        {
            if (numberOfImagesNeeded == 0)
            {
                return ShuffleCollection(images).ToList();
            } 
            else if (numberOfImagesNeeded < 0 ) 
            {
                return null;            
            }
            return ShuffleCollection(images).Take(numberOfImagesNeeded).ToList();
        }


    }
}

