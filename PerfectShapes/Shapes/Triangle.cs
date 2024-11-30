namespace PerfectShapes.Shapes;

public class Triangle : AbstractShape
{
    private double a;
    private double b;
    private double c;

    public Triangle(double sideA, double sideB, double sideC)
    {
        this.a = sideA;
        this.b = sideB;
        this.c = sideC;
    }

    public override double Area => this.СalculateArea();

    private double СalculateArea()
    {
        var p = (a + b + c) / 2;
        return Math.Sqrt(p * (p-a) * (p-b) * (p-c));
    }
    
    public bool IsRightTriangle()
    {
        double[] sides = { a, b, c };
        Array.Sort(sides);
        var hypotenuseSquare = sides[2] * sides[2];
        var catet1Square = sides[0] * sides[0];
        var catet2Square = sides[1] * sides[1];
        return Math.Abs(hypotenuseSquare - (catet1Square + catet2Square)) < 1e-10;
    }
}