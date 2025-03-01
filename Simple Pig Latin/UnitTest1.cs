namespace Simple_Pig_Latin
{
    public class Tests
    {
        [Test]
        public void KataTests()
        {
            Assert.That(Kata.PigIt("Pig latin is cool"), Is.EqualTo("igPay atinlay siay oolcay"));
            Assert.That(Kata.PigIt("This is my string"), Is.EqualTo("hisTay siay ymay tringsay"));
        }
    }
}