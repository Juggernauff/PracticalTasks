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
            double correctArea = 6;

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
            double correctArea = 0;

            //Act
            var result = triangle.Area;

            //Assert
            Assert.Equal(correctArea, result);
        }
    }
}
