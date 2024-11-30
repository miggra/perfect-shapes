using PerfectShapes.Shapes;

namespace PerfectShapes.Tests.Shapes;

public class CircleTests
{
    [Theory]
    [InlineData(5, 78.54)]
    [InlineData(10, 314.16)]
    public void Area_ShouldReturnCorrectArea(double radius, double expectedArea)
    {
        // Arrange
        var circle = new Circle(radius);

        // Act
        var area = circle.Area;

        // Assert
        Assert.Equal(expectedArea, area, 2);
    }
}