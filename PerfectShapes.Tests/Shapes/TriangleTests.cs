using PerfectShapes.Shapes;

namespace PerfectShapes.Tests.Shapes;

public class TriangleTests
{
    [Theory]
    [InlineData(3, 4, 5, 6)]
    [InlineData(6, 8, 10, 24)]
    public void Area_ShouldReturnCorrectArea(double a, double b, double c, double expectedArea)
    {
        // Arrange
        var triangle = new Triangle(a, b, c);

        // Act
        var area = triangle.Area;

        // Assert
        Assert.Equal(expectedArea, area, 2);
    }

    [Theory]
    [InlineData(3, 4, 5, true)]
    [InlineData(3, 4, 6, false)]
    public void IsRightTriangle_ShouldReturnCorrectResult(double a, double b, double c, bool expectedResult)
    {
        // Arrange
        var triangle = new Triangle(a, b, c);

        // Act
        var isRightTriangle = triangle.IsRightTriangle();

        // Assert
        Assert.Equal(expectedResult, isRightTriangle);
    }
}   