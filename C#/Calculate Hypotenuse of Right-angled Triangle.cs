
internal class Kata
{
    public static double CalculateHypotenuse(double a, double b)
    {
        //a ^ 2 + b ^ 2 = c ^ 2

        if (a <= 0 || b <= 0 || double.IsNaN(a) || double.IsNaN(b))
            throw new ArgumentException();

        double d = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        double result = Math.Round(d, 3);
        return result;
    }
}
