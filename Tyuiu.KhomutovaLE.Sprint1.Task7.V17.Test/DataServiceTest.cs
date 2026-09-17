using Tyuiu.KhomutovaLE.Sprint1.Task7.V17.Lib;

namespace Tyuiu.KhomutovaLE.Sprint1.Task7.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidEx()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 5;
            double chisl = 1 + Math.Sin(Math.Sqrt(x * x + 1));
            double znam = Math.Cos(12 * y - 4);
            double z = Math.Round(chisl / znam, 3);
            var res = ds.Calculate(x, y);
            Assert.AreEqual(z, res);
        }
    }
}
