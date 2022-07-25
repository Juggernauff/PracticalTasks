using Shapes;
using Xunit;

namespace UnitTests
{
    public class CircleTests
    {
        [Fact]
        public void CalculatingArea_Input1_OutputPI_ReturnTrue()
        {
            //Arrange
            var circle = new Circle(1);
            double correctArea = System.Math.PI;

            //Act
            var result = circle.Area;

            //Assert
            Assert.Equal(correctArea, result);
        }
        [Fact]
        public void CalculatingArea_Input0_Output0_ReturnTrue()
        {
            //Arrange
            var circle = new Circle(0);
            double correctArea = 0;

            //Act
            var result = circle.Area;

            //Assert
            Assert.Equal(correctArea, result);
        }
    }
}
