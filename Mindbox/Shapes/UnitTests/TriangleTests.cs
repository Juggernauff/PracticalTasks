using Xunit;
using Shapes;

namespace UnitTests
{
    public class TriangleTests
    {
        [Fact]
        public void CalculatingArea_Input3and4and5_Output6_ReturnTrue()
        {
            //Arrange
            var triangle = new Triangle(3, 4, 5);
            var correctArea = 6;

            //Act
            var result = triangle.Area;

            //Assert
            Assert.Equal(correctArea, result);
        }
        [Fact]
        public void CalculatingArea_Input1and1and2_Output0_ReturnTrue()
        {
            //Arrange
            var triangle = new Triangle(1, 1, 2);
            var correctArea = 0;

            //Act
            var result = triangle.Area;

            //Assert
            Assert.Equal(correctArea, result);
        }
        [Fact]
        public void TriangleIsRectangular_Input3and5and5_OutputTrue_ReturnTrue()
        {
            //Arrange
            var triangle = new Triangle(3, 4, 5);

            //Act
            var result = triangle.IsRectangular();

            //Assert
            Assert.True(result);
        }
        [Fact]
        public void TriangleIsRectangular_Input1and2and3_OutputFalse_ReturnTrue()
        {
            //Arrange
            var triangle = new Triangle(1, 2, 3);

            //Act
            var result = triangle.IsRectangular();

            //Assert
            Assert.False(result);
        }
    }
}
