namespace IdentifyBallBearings
{
    public class Tests
    {
        public static void RunTest(Bearing[] bearings, Bearing expected)
        {
            var callCount = 0;
            Func<IEnumerable<Bearing>, long> weighFunction = a => {
                callCount++;
                return a.Sum(x => x == expected ? 11 : 10);
            };
            Assert.That(UserSolution.IdentifyBb(bearings, weighFunction), Is.SameAs(expected));
            Assert.That(callCount, Is.EqualTo(1), "You can call the 'weigh' function only once");
        }

        [Test]
        public void SampleTests()
        {
            var (a, b, c, d, e) = (new Bearing(0), new Bearing(1), new Bearing(2), new Bearing(3), new Bearing(4));
            RunTest(new[] { a, b }, a);
            RunTest(new[] { a, b, c }, c);
            RunTest(new[] { a, b, c }, b);
            RunTest(new[] { a, b, c, d, e }, d);
        }
    }
}