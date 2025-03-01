namespace Latin_Squares
{
    public class Tests
    {
        [Test]
        public void FixedTests()
        {
            for (int i = 1; i <= 10; i++)
            {
                int[,] square = LatinSquare.MakeLatinSquare(i);
                Tuple<bool, string> verification = Preloaded.VerifyLatinSquare(square, i);
                bool result = (bool)verification.Item1;
                string message = (string)verification.Item2;
                Assert.That(result, Is.True, message);
            }
        }
    }
}