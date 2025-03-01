namespace Product_Array__Array_Series__5_
{
    internal class Kata
    {
        public static int[] ProductArray(int[] array)
        {
            int[] products = new int[array.Length];
            Array.Fill(products, 1);

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (j != i)
                        products[i] *= array[j];
                }
            }

            return products;
        }
    }
}
