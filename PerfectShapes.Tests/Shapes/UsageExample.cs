using PerfectShapes.Shapes;

namespace PerfectShapes.Tests.Shapes;

public class UsageExample
{
    [Fact]
    public void CalculateAreaGettingShapeTypesOnRuntimeExample()
    {
        var shapes = new List<AbstractShape>
        {
            new Circle(5),
            new Triangle(3, 4, 5)
        };

        foreach (var shape in shapes)
        {
            Console.WriteLine($"Shape area: {shape.Area}");
        }
    }
}