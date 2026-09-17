using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KhomutovaLE.Sprint1.Task7.V17.Lib
{
    public class DataService : ISprint1Task7V17
    {
        public double Calculate(double x, double y)
        {
            double chisl = 1 + Math.Sin(Math.Sqrt(x * x + 1));
            double znam = Math.Cos(12 * y - 4);
            double z = Math.Round(chisl / znam, 3);
            return z;
        }
    }
}
