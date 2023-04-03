namespace Mindbox.Test;

public class SquareCalculatorTest
{
    [Fact]
    public void CalculateShapeSquare()
    {
        var shapes = new List<ISquare>
        {
            new Circle(1), new Circle(12),
            new Rectangle(1, 1), new Rectangle(11, 2),
            new Triangle(3, 4, 5), new Triangle(10, 6, 6)
        };

        Assert.All(shapes, square => { Assert.True(square.Square() > 0); });
    }
}