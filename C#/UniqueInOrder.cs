
internal class Kata
{
    public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
    {
        T target = default(T);
        List<T> result = new List<T>();

        foreach (var element in iterable)
        {
            if (EqualityComparer<T>.Default.Equals(target, default(T)) || !EqualityComparer<T>.Default.Equals(target, element))
            {
                target = element;
                result.Add(element);
            }
        }

        return result;
    }
}
