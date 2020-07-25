using GoMemory.Common.Models;


using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace GoMemory.Helpers
{
    public  class ImageHelper
    {

        //TODO get a list of the local image and store there path and name in a list of ImageTiles then store global 
        
        public  List<ImageTile> _images;
        public HttpClient httpClient { get; set; }


  public string img { get; set; } = "images/apple.png";
        
        public async Task<string> GetAllImages() 
        {
            var assembly = Assembly.GetExecutingAssembly();
            var names = assembly.GetManifestResourceNames();
            string result;
            foreach (var file in names)
            {
                using (Stream stream = assembly.GetManifestResourceStream(file))
                using (StreamReader streamReader = new StreamReader(stream))
                {
                    result = streamReader.ReadToEnd();
                }
            }
              var i = img;

            return i;
            //try
            //{
            //    var images = await httpClient.GetAsync("Images/apple.png");

            //}
            //catch (Exception ex)
            //{

            //    throw;
            //}

           // if (images == null) { return null; }

            //for (int i = 0; i < images.Length; i++)
            //{ }

            //_images.Add(new ImageTile
            //{
            //    Path = images[i],
            //    Name = Path.GetFileName(images[i])
            //});
            ////}

            return null;
        }

        //string[] _ima;
        //public ImageHelper() => _ima = new string[]
        //    {
        //         "apple.png",
        //        "beer.png",
        //        "bell.png",
        //        "bison.png",
        //        "cake.png",
        //        "camera.png",
        //       "carrot.png",
        //        "cheese.png",
        //        "chocolate.png",
        //        "clock.png",
        //        "codfish.png",
        //        "crab.png",
        //        "egg.png",
        //        "frog.png",
        //        "hammer.png",
        //        "lightbulb.png",
        //        "lightning.png",
        //        "lolly.png",
        //        "microphone.png",
        //        "milkshake.png",
        //        "orange.png",
        //        "parrot.png",
        //        "phone.png",
        //        "pig.png",
        //        "portobello.png",
        //        "rabbit.png",
        //        "robots.png",
        //        "sausage.png",
        //        "scissors.png",
        //        "spider.png",
        //        "star.png",
        //        "strawberry.png",
        //        "teapot.png",
        //        "wasp.png",
        //        "watermelon.png",
        //        "wine.png"

        //    };


        /// <summary>
        /// zero argument method for getting a unmodified ObservableCollection of Image
        /// </summary>
        /// <returns>
        /// ObservableCollection of Image
        /// </returns>
        //public Image[] GetImages(int totalImages)
        //{
        //    return ShuffleCollection(_images).Take(totalImages).ToArray();
        //}

        /// <summary>
        /// Randomize the order of a Image Array
        /// </summary>
        /// <returns>
        /// ObservableCollection of Image
        /// </returns>
        //public Image[] ShuffleCollection(Image[] imageArray)
        //{
        //    Random rnd = new Random();
        //    Image[] unsorted = imageArray;
        //    for (int i = 0; i < unsorted.Length; i++)
        //    {
        //        Image temp = unsorted[i];
        //        int randomIndex = rnd.Next(0, imageArray.Length);
        //        unsorted[i] = unsorted[randomIndex];
        //        unsorted[randomIndex] = temp;
        //    }
        //    return unsorted;
        // }

        //public Image[] ToMatchImagesList(int numberOfImagesNeeded, Image[] images)
        //{
        //    return ShuffleCollection(images).Take(numberOfImagesNeeded).ToArray();
        //}




        //public Image[] ToMatchImagesArray(Image[] selectFromImages)
        //{
        //    Random rnd = new Random();
        //    int maxIndex = selectFromImages.Length;
        //    Image[] matchImages = new Image[maxIndex];
        //    for (int i = 0; i < selectFromImages.Length; i++)
        //    {
        //        Image selectedImage = selectFromImages[rnd.Next(0, maxIndex)];
        //        if (matchImages.Contains(selectedImage)) continue;
        //        matchImages[i] = selectedImage;
        //    }
        //    return matchImages;

        //}
    }
}
