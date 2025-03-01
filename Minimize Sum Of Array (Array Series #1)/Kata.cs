namespace Minimize_Sum_Of_Array__Array_Series__1_
{
    internal class Kata
    {
        public static int MinSum(int[] a)
        {
            Array.Sort(a);

            int sum = 0;

            for (var i = 0; i < a.Length / 2; i++)
            {
                sum += a[i] * a[a.Length - 1 - i];
            }

            return sum;
        }
    }
}
