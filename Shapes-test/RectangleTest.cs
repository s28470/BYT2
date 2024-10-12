using Tut2_s20123;

namespace Shapes_test;

[TestFixture]
[TestOf(typeof(Rectangle))]
public class RectangleTest
{

    private IShape rectangle;

    [SetUp]
    public void SetUp()
    {
        rectangle = new Rectangle(4,8);
    }

    [Test]
    public void TestRectangleCalculateArea()
    {
        Assert.That(rectangle.CalculateArea(), Is.EqualTo(32));
    }

    [Test]
    public void TestRectangleCalculateVolume()
    {
        Assert.That(rectangle.CalculateVolume(), Is.EqualTo(0));
    }
}