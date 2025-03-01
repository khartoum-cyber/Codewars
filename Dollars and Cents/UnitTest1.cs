namespace Dollars_and_Cents
{
    public class Tests
    {
        [Test]
        public void SampleTest()
        {
            Assert.That(Kata.FormatMoney(39.99), Is.EqualTo("$39.99"), "That's not formatted the way we expected.");
        }
    }
}