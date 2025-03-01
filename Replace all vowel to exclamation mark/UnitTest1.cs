namespace Replace_all_vowel_to_exclamation_mark
{
    public class Tests
    {
        [Test, Description("Basic Tests")]
        public void BasicTest()
        {
            Assert.That(Kata.Replace("Hi!"), Is.EqualTo("H!!"));
            Assert.That(Kata.Replace("!Hi! Hi!"), Is.EqualTo("!H!! H!!"));
            Assert.That(Kata.Replace("aeiou"), Is.EqualTo("!!!!!"));
            Assert.That(Kata.Replace("ABCDE"), Is.EqualTo("!BCD!"));
        }
    }
}