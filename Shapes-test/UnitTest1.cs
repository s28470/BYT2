using Tut2_s20123;

namespace Tut2_s20123_Tests
{
    [TestFixture]
    public class Tests
    {
        private IShape sphere;

        
        [SetUp]
        public void SetUp()
        {
            sphere = new Sphere(5);
        }

        [Test]
        public void TestSphereCalculateArea()
        {
            Assert.That(sphere.CalculateArea(), Is.EqualTo(314.159).Within(0.001));
        }

        [Test]
        public void TestSphereCalculateVolume()
        {
            Assert.That(sphere.CalculateVolume(), Is.EqualTo(523.598).Within(0.001));
        }

    }
}