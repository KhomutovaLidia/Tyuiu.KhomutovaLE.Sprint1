using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KhomutovaLE.Sprint1.Task5.V6.Lib
{
    public class DataService : ISprint1Task5V6
    {
        public int Calculate(int k)
        {
            int n = 0;
            for (int i = 1; i <= k; i++)
            {
                n++;
                if (n == 7)
                {
                    n = 0;
                }
            }
            return n;
        }
    }
}
