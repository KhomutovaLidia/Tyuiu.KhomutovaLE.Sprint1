using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KhomutovaLE.Sprint1.Task4.V24.Lib
{
    public class DataService : ISprint1Task4V24
    {
        public double Calculate(double x, double y)
        {
            double chisl = Math.Log(x * y, Math.Exp(1));
            return Math.Round((chisl / (x + Math.Sqrt(2 * y * y))), 3);
        }
    }
}
