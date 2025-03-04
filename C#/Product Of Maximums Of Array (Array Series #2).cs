
internal class Kata
{
    public static int MaxProduct(int[] arr, int size)
    {
        //var product = 1;

        //Array.Sort(arr);

        //for (var i = arr.Length - 1; i >= arr.Length - size; i--)
        //{
        //    product *= arr[i];
        //}

        //return product;

        return arr.OrderBy(i => -i).Take(size).Aggregate((x, y) => x * y);
    }
}
