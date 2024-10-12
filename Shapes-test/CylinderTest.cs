using Tut2_s20123;

namespace Shapes_test;

[TestFixture]
[TestOf(typeof(Cylinder))]
public class CylinderTest
{
    private IShape cylinder;

    [SetUp]
    public void SetUp()
    {
        cylinder = new Cylinder(3, 7);
    }

    [Test]
    public void TestCylinderCalculateArea()
    {
        Assert.That(cylinder.CalculateArea(), Is.EqualTo(188.496).Within(0.001));
    }

    [Test]
    public void TestCylinderCalculateVolume()
    {
        Assert.That(cylinder.CalculateVolume(), Is.EqualTo(197.92).Within(0.001));
    }
}