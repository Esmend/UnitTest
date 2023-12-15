namespace MyLibrary
{
    public class Mylibrary
    {
        public double Add(double x, double y)
        {
            return x + y  ;
        }
        public double Subtract(double x, double y)
        {
            return x - y;
        }
        public double Multiply(double x, double y)
        {
            return x * y;
        }
        public double Divide(double x, double y)
        {
            return x / y;
        }

        public double Pow(double x, double y)
        {
            double result = 1;
            for (double i = 0; i < y; i++)
            {
                result *= x;
            }
            return result;
        }

        public double Sqrt(double x)
        {
            double res = 1;
            res /= x;
            return res;
        }
    }
}