using GoMemory.Shared.Interfaces;
using GoMemory.Shared.Models;
using GoMemory.Helpers;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
namespace GoMemory.Tests.HelperTests
{

    public class ImageHelperTests
    {
        Mock<IImageHelper> sut;

        public ImageHelperTests()
        {
            sut = new Mock<IImageHelper>();
        }

        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        public void GetImagesShouldReturnAImageTileListOfSpecifiedLength(int amount)
        {
            //Arrange
            List<ImageTile> temp = 
                new List<ImageTile> { It.IsAny<ImageTile>(), It.IsAny<ImageTile>(), It.IsAny<ImageTile>(), It.IsAny<ImageTile>(), };
            sut.Setup(x => x.GetImages(It.IsAny<int>())).Returns(temp.Take(amount).ToList());
           //Act
            var result = sut.Object.GetImages(amount);

            //Assert
            Assert.NotNull(result);
            Assert.IsType<List<ImageTile>>(result);
            Assert.Equal(amount,result.Count() );
        }

        [Theory]
        [InlineData(-2)]
        [InlineData(0)]
        [InlineData(-1)]
        public void GetImagesShouldReturnEmptyListIfAmountIsZeroOrLess(int amount)
        {
            //Arrange
            List<ImageTile> temp = null;
            sut.Setup(x => x.GetImages(It.IsAny<int>())).Returns(temp);
            var result = sut.Object.GetImages(amount);

            //Assert
            Assert.Null(result);
       
            
        }


        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        public void ToMatchImageTileListShouldReturnAImageTileListOfSpecifiedLength(int amount)
        {
            //Arrange
            List<ImageTile> temp =
                new List<ImageTile> { It.IsAny<ImageTile>(), It.IsAny<ImageTile>(), It.IsAny<ImageTile>(), It.IsAny<ImageTile>(), };
            sut.Setup(x => x.ToMatchImageTileList(It.IsAny<int>(),It.IsAny<List<ImageTile>>())).Returns(temp.Take(amount).ToList());
            //Act
            var result = sut.Object.ToMatchImageTileList(amount,temp);

            //Assert
            Assert.NotNull(result);
            Assert.IsType<List<ImageTile>>(result);
            Assert.Equal(amount, result.Count());
        }

        [Theory]
        [InlineData(-2)]
        [InlineData(-99)]
        [InlineData(-1)]
        public void ToMatchImageTileListShouldReturnNullForNegativeNumbers(int amount)
        {
            //Arrange
            List<ImageTile> temp = null;
            sut.Setup(x => x.ToMatchImageTileList(It.IsAny<int>(), It.IsAny<List<ImageTile>>())).Returns(temp);
            var result = sut.Object.ToMatchImageTileList(amount,temp);

            //Assert
            Assert.Null(result);

        }

        [Theory]
        [InlineData(0)] 
        public void ToMatchImageTileListShouldReturnAImageTileListOfAllImages(int amount)
        {
            //Arrange
            List<ImageTile> temp =
                new List<ImageTile> { It.IsAny<ImageTile>(), It.IsAny<ImageTile>(), It.IsAny<ImageTile>(), It.IsAny<ImageTile>(), };
            sut.Setup(x => x.ToMatchImageTileList(It.IsAny<int>(), It.IsAny<List<ImageTile>>())).Returns(temp.ToList());
            //Act
            var result = sut.Object.ToMatchImageTileList(amount, temp);

            //Assert
            Assert.NotNull(result);
            Assert.IsType<List<ImageTile>>(result);
            Assert.Equal(temp.Count(), result.Count());
        }

    }

}
