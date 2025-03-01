namespace Product_Array__Array_Series__5_
{
    public class Tests
    {
        [TestCase("12 20", "20 12")]
        [TestCase("3 27 4 2", "216 24 162 324")]
        [TestCase("13 10 5 2 9", "900 1170 2340 5850 1300")]
        [TestCase("16 17 4 3 5 2", "2040 1920 8160 10880 6528 16320")]
        public void BasicTest(string s, string str)
        {
            Assert.That(Kata.ProductArray(Foo(s)), Is.EqualTo(Foo(str)));
        }
        int[] Foo(string s) => s.Split().Select(int.Parse).ToArray();
    }
}