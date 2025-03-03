namespace Nth_Smallest_Element__Array_Series__4_
{
    internal class Kata
    {
        public static int NthSmallest(int[] arr, int pos)
        {
            return arr.OrderBy(n => n).ElementAt(pos - 1);
        }
    }
}