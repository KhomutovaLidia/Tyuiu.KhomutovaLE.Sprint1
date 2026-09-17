using Tyuiu.KhomutovaLE.Sprint1.Task4.V24.Lib;

namespace Tyuiu.KhomutovaLE.Sprint1.Task4.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidEx()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 7;
            double chisl = Math.Log(x * y, Math.Exp(1));
            double wait = Math.Round((chisl / (x + Math.Sqrt(2 * y * y))), 3);
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
