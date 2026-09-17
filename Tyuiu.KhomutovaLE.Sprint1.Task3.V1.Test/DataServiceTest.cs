using Tyuiu.KhomutovaLE.Sprint1.Task3.V1.Lib;

namespace Tyuiu.KhomutovaLE.Sprint1.Task3.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidEx()
        {
            DataService ds = new DataService();
            double r = 2;
            double h = 5;
            double num = Math.PI * r * r * h;
            double wait = Math.Round(num, 3);
            var res = ds.CylinderVolume(r, h);
            Assert.AreEqual(wait, res);

        }
    }
}
