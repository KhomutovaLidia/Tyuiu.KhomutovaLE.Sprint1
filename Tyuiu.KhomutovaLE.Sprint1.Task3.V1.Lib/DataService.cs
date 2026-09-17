using tyuiu.cources.programming.interfaces.Sprint1;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tyuiu.KhomutovaLE.Sprint1.Task3.V1.Lib
{
    public class DataService : ISprint1Task3V1
    {
        public double CylinderVolume(double r, double h)
        {
            double num = Math.PI * r * r * h;
            double res = Math.Round(num, 3);
            return res;
        }
    }
}
