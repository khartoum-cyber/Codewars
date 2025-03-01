namespace Find_out_whether_the_shape_is_a_cube
{
    public class Tests
    {
        [Test, Order(1)]
        public void ShouldReturnFalse()
        {
            CubeChecker cube = new CubeChecker();
            Assert.That(cube.IsCube(1, 1), Is.EqualTo(true));
            Assert.That(cube.IsCube(8, 2), Is.EqualTo(true));
        }

        [Test, Order(2)]
        public void ShouldReturnTrue()
        {
            CubeChecker cube = new CubeChecker();
            Assert.That(cube.IsCube(2, 1), Is.EqualTo(false));
            Assert.That(cube.IsCube(6, 3), Is.EqualTo(false));
            Assert.That(cube.IsCube(-8, -2), Is.EqualTo(false));
            Assert.That(cube.IsCube(0, 0), Is.EqualTo(false));
            Assert.That(cube.IsCube(200, 4), Is.EqualTo(false));
        }
    }
}