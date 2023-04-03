namespace Mindbox.Test;

public class TriangleTest
{
    [Fact]
    public void CheckRightTriangle()
    {
        var t = new Triangle(4, 5, 3);
        Assert.True(t.IsRightTriangle());
        Assert.Equal(6, t.Square());
    }

    [Fact]
    public void CheckTriangleArgGuard()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(1, 5, 1));
        Assert.Throws<ArgumentException>(() => new Triangle(-1, -1, 0));
    }
}