using Tut2_s20123;

namespace Shapes_test;

[TestFixture]
[TestOf(typeof(Cube))]
public class CubeTest
{
    private IShape cube;

    [SetUp]
    public void SetUp()
    {
        cube = new Cube(4);
    }

    [Test]
    public void TestCubeCalculateArea()
    {
        Assert.That(cube.CalculateArea(), Is.EqualTo(96));
    }

    [Test]
    public void TestCubeCalculateVolume()
    {
        Assert.That(cube.CalculateVolume(), Is.EqualTo(64));
    }
}