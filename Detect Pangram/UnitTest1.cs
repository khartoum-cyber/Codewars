namespace Detect_Pangram
{
    public class Tests
    {
        [Test]
        public void SampleTests()
        {
            Assert.That(Kata.IsPangram("The quick brown fox jumps over the lazy dog."), Is.EqualTo(true));
        }
    }
}