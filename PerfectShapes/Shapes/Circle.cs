namespace PerfectShapes.Shapes;
public class Circle : AbstractShape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double Area => Math.PI * radius * radius;
}