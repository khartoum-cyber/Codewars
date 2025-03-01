namespace Say_Me_Please_Operations
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class KataTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.That(Kata.sayMeOperations("1 2 3 5 8"), Is.EqualTo("addition, addition, addition"));
            Assert.That(Kata.sayMeOperations("9 4 5 20 25"), Is.EqualTo("subtraction, multiplication, addition"));
            Assert.That(Kata.sayMeOperations("10 2 5 -3 -15 12"), Is.EqualTo("division, subtraction, multiplication, subtraction"));
            Assert.That(Kata.sayMeOperations("2 2 4"), Is.EqualTo("addition"));
        }

        [Test]
        public void ShouldRemoveAllVowels()
        {
            Assert.That(Kata.Disemvowel("This website is for losers LOL!"), Is.EqualTo("Ths wbst s fr lsrs LL!"), "Incorrect answer for input=\"This website is for losers LOL!\"");
        }

        [Test]
        public void MultilineString()
        {
            Assert.That(Kata.Disemvowel("No offense but,\nYour writing is among the worst I've ever read"), Is.EqualTo("N ffns bt,\nYr wrtng s mng th wrst 'v vr rd"), "Incorrect answer for input=\"No offense but,\nYour writing is among the worst I've ever read\"");
        }

        [Test]
        public void OneMoreForGoodMeasure()
        {
            Assert.That(Kata.Disemvowel("What are you, a communist?"), Is.EqualTo("Wht r y,  cmmnst?"), "Incorrect answer for input=\"What are you, a communist?\"");
        }
    }
}