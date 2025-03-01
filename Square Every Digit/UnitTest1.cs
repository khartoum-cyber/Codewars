namespace Square_Every_Digit
{
    public class Tests
    {
        [Test]
        public void SquareDigitsTest()
        {
            Assert.That(Kata.SquareDigits(9119), Is.EqualTo(811181), "Incorrect answer for n=9119");
            Assert.That(Kata.SquareDigits(0), Is.EqualTo(0), "Incorrect answer for n=0");
        }
    }
}